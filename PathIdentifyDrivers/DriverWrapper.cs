﻿using DAL;
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
                        {
                            driver = new HanvonDriver();
                        } break;
                    case 2:
                        {
                            driver = new SignalwayDriver();
                        } break;
                    case 3:
                        {
                            driver = new HitDriver();
                        } break;
                    default:
                        {
                            throw new Exception("未定义的驱动类型，ProtocolId=" + pid.ToString());
                        }
                }
                if (driver == null)
                {
                    throw new Exception("没有驱动程序被初始化");
                }
                else
                {
                    driver.DeviceStatusNotifyHandler = OnDeviceStatusChanged;
                    driver.VehicleInfoReceiveHandler = OnVehicleInfoNotify;
                    rel = driver.InitDriver(currentList);
                    DriverDict.Add(pid, driver);
                }
            }

            return rel;
        }

        public static bool Connect(int ParentEquipId)
        {
            int protocolId = Cache.PathIdEquips.Where(it => it.ParentId == ParentEquipId).Select(it => it.ProtocolId).FirstOrDefault();
            if (DriverDict.Keys.Contains(protocolId))
            {
                return DriverDict[protocolId].Connect(ParentEquipId);
            }
            else
            {
                throw new Exception("执行Wrapper中Connect方法时发现驱动程序未被正常初始化，ParentEquipId：" + ParentEquipId.ToString());
            }
        }

        public static bool Disconnect(int ParentEquipId)
        {
            int protocolId = Cache.PathIdEquips.Where(it => it.Id == ParentEquipId).Select(it => it.ProtocolId).FirstOrDefault();
            if (DriverDict.Keys.Contains(protocolId))
            {
                return DriverDict[protocolId].Disconnect(ParentEquipId);
            }
            else
            {
                throw new Exception("执行Wrapper中Disconnect方法时发现驱动程序未被正常初始化，ParentEquipId：" + ParentEquipId.ToString());
            }
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
            string nameid = string.Format("{0}{1}", string.IsNullOrEmpty(arg.VehiclePlateNo) ? "无牌" : arg.VehiclePlateNo,
            arg.ReachTime.ToString("HHmmss"));

            T_ReceiveData data = new T_ReceiveData();
            data.EquipId = arg.Device.Id;

            #region 保存图片

            if (arg.PanoramaPhoto != null && arg.PanoramaPhoto.Length > 0)
            {
                string PanoramaPhotoPath = path + nameid + "_All.jpg";
                FileIOUtil.SaveFileByByteArray(PanoramaPhotoPath, arg.PanoramaPhoto);
                data.ImageAllPath = PanoramaPhotoPath;
            }
            if (arg.CloseShotPhoto != null && arg.CloseShotPhoto.Length > 0)
            {
                string CloseShotPhotoPath = path + nameid + "_Near.jpg";
                FileIOUtil.SaveFileByByteArray(CloseShotPhotoPath, arg.CloseShotPhoto);
                data.ImageNearPath = CloseShotPhotoPath;
            }

            if (arg.VehiclePlatePhoto != null && arg.VehiclePlatePhoto.Length > 0)
            {
                string VehiclePlatePhotoPath = path + nameid + "_VehiclePlate.jpg";
                FileIOUtil.SaveFileByByteArray(VehiclePlatePhotoPath, arg.VehiclePlatePhoto);
                data.ImagePlateNoPath = VehiclePlatePhotoPath;
            }

            if (arg.VehiclePlateBinPhoto != null && arg.VehiclePlateBinPhoto.Length > 0)
            {
                string BinVehiclePlatePhotoPath = path + nameid + "_Bin.jpg";
                FileIOUtil.SaveFileByByteArray(BinVehiclePlatePhotoPath, arg.VehiclePlateBinPhoto);
                data.ImageBinPlateNoPath = BinVehiclePlatePhotoPath;
            }

            #endregion 保存图片

            data.ReachTime = arg.ReachTime;
            data.VehicleLength = arg.VehicleLength;
            data.VehicleSpeed = arg.VehicleSpeed;
            data.VehPlateColor = string.IsNullOrEmpty(arg.VehiclePlateColor) ? "未知" : arg.VehiclePlateColor;
            data.VehPlateNo = arg.VehiclePlateNo;
            DAL_ReceiveData.SaveReceiveData(data);
            arg.DbData = data;
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

        public static bool SetRetransData(int equipId, DateTime startTime, DateTime endTime)
        {
            T_PathIdentifyEquip equip = Cache.PathIdEquips.Where(it => it.Id == equipId).FirstOrDefault();
            int protocolId = equip.ProtocolId;

            if (DriverDict.Keys.Contains(protocolId))
            {
                return DriverDict[protocolId].SetRetransferTime(equip.Id, startTime, endTime);
            }
            else
            {
                throw new Exception(string.Format("设置重传时未能发现正确的驱动类型。EquipId={0},ProtocolId={1}", equipId, protocolId));
            }
        }

        public static bool GetConnectStatus(int equipId)
        {
            int protocolId = Cache.PathIdEquips.Where(it => it.Id == equipId).Select(it => it.ProtocolId).FirstOrDefault();
            if (DriverDict.Keys.Contains(protocolId))
            {
                return DriverDict[protocolId].GetConnectStatus(equipId);

                //return DriverDict[protocolId].SetEquipTime(equipId, DateTime.Now);
            }
            else
            {
                throw new Exception(string.Format("获取设备状态时未能发现正确的驱动类型。EquipId={0},ProtocolId={1}", equipId, protocolId));
            }
        }
    }
}