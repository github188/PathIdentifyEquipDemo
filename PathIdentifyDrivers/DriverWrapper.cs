using DAL;
using DataDict.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Util;

namespace PathIdentifyDrivers
{
    /// <summary>
    /// 驱动分解器，主调用入口，调用步骤为：1、挂载设备状态和数据回调的事件接口；
    /// 2、初始化驱动，调用Init方法
    /// </summary>
    public static class DriverWrapper
    {
        private static Dictionary<int, PathIdentifyDriverInterface> DriverDict = new Dictionary<int, PathIdentifyDriverInterface>();

        /// <summary>
        /// 设备状态回调句柄
        /// </summary>
        public static EventHandler<DeviceStatus> DeviceStatusNotifyHandler;

        /// <summary>
        /// 设备数据回调句柄
        /// </summary>
        public static EventHandler<VehicleInfoReceiveEventArgs> VehicleInfoReceiveNotifyHandler;

        /// <summary>
        /// 图片保存路径
        /// </summary>
        public static string ImageSavePath
        { get; set; }

        public static bool Init(string iamgePath)
        {
            bool rel = false;

            ImageSavePath = iamgePath;
            if (!Directory.Exists(ImageSavePath))
            {
                Directory.CreateDirectory(ImageSavePath);
            }
            int[] distinctProtocolIds = Cache.PathIdEquips.Select(it => it.ProtocolId).Distinct().ToArray();

            foreach (int pid in distinctProtocolIds)
            {
                List<T_PathIdentifyEquip> currentList = Cache.PathIdEquips.Where(it => it.ProtocolId == pid).ToList();

                PathIdentifyDriverInterface driver = null;

                switch (pid)
                {
                    case 1:
                        { } break;
                    case 2:
                        {
                            driver = new SignalwayDriver();
                        } break;
                    case 3:
                        {
                        } break;
                    default:
                        {
                            throw new Exception("未定义的驱动类型，ProtocolId=" + pid.ToString());
                        }
                }
                driver.DeviceStatusNotifyHandler = OnDeviceStatusChanged;
                rel = driver.InitDriver(currentList);
                DriverDict.Add(pid, driver);
            }

            return rel;
        }

        #region 事件回调处理

        /// <summary>
        /// 设备状态改变回调方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="status"></param>
        private static void OnDeviceStatusChanged(object sender, DeviceStatus status)
        {
            T_DeviceStatusLog log = new T_DeviceStatusLog();
            log.EquipId = status.Device.Id;
            log.StatusDesc = status.StatusDesc;
            log.StatusId = status.Status.GetHashCode();
            DAL_DeviceStatus.SaveDeviceStatus(log);

            if (DeviceStatusNotifyHandler != null)
            {
                DeviceStatusNotifyHandler.Invoke(sender, status);
            }
        }

        private static void OnVehicleInfoNotify(object sender, VehicleInfoReceiveEventArgs arg)
        {
            string path = ImageSavePath + arg.Device.Id.ToString() + DateTime.Now.ToString("yyyyMMdd") + "\\";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            Guid nameid = Guid.NewGuid();

            T_ReceiveData data = new T_ReceiveData();
            data.EquipId = arg.Device.Id;

            #region 保存图片

            if (arg.PanoramaPhoto != null && arg.PanoramaPhoto.Length > 0)
            {
                string PanoramaPhotoPath = path + nameid.ToString() + "ImageAll.jpg";
                FileIOUtil.SaveFileByByteArray(PanoramaPhotoPath, arg.PanoramaPhoto);
                data.ImageAllPath = PanoramaPhotoPath;
            }
            if (arg.CloseShotPhoto != null && arg.CloseShotPhoto.Length > 0)
            {
                string CloseShotPhotoPath = path + nameid.ToString() + "ImageNear.jpg";
                FileIOUtil.SaveFileByByteArray(CloseShotPhotoPath, arg.CloseShotPhoto);
                data.ImageNearPath = CloseShotPhotoPath;
            }

            if (arg.VehiclePlatePhoto != null && arg.VehiclePlatePhoto.Length > 0)
            {
                string VehiclePlatePhotoPath = path + nameid.ToString() + "VehiclePlatePhoto.jpg";
                FileIOUtil.SaveFileByByteArray(VehiclePlatePhotoPath, arg.VehiclePlatePhoto);
                data.ImagePlateNoPath = VehiclePlatePhotoPath;
            }

            if (arg.VehiclePlateBinPhoto != null && arg.VehiclePlateBinPhoto.Length > 0)
            {
                string BinVehiclePlatePhotoPath = path + nameid.ToString() + "BinVehiclePlatePhoto.jpg";
                FileIOUtil.SaveFileByByteArray(BinVehiclePlatePhotoPath, arg.VehiclePlateBinPhoto);
                data.ImageBinPlateNoPath = BinVehiclePlatePhotoPath;
            }

            #endregion 保存图片

            data.ReachTime = arg.ReachTime;
            data.VehicleLength = arg.VehicleLength;
            data.VehicleSpeed = arg.VehicleSpeed;
            data.VehPlateColor = arg.VehiclePlateColor;
            data.VehPlateNo = arg.VehiclePlateNo;
            DAL_ReceiveData.SaveReceiveData(data);
            if (VehicleInfoReceiveNotifyHandler != null)
            {
                VehicleInfoReceiveNotifyHandler.Invoke(sender, arg);
            }
        }

        #endregion 事件回调处理

        public static bool ProofTime(int equipId)
        {
            int protocolId = Cache.PathIdEquips.Where(it => it.Id == equipId).Select(it => it.ProtocolId).FirstOrDefault();
            if (DriverDict.Keys.Contains(protocolId))
            {
                return DriverDict[protocolId].SetEquipTime(equipId, DateTime.Now);
            }
            else
            {
                throw new Exception(string.Format("校时时未能发现正确的驱动类型。EquipId={0},ProtocolId={1}", equipId, protocolId));
            }
        }
    }
}