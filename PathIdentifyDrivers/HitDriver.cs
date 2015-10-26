using DAL;
using DataDict.Dicts;
using DataDict.Models;
using HitSysPathIdDriver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PathIdentifyDrivers
{
    /// <summary>
    /// 哈工大抓拍设备驱动
    /// </summary>
    public class HitDriver : PathIdentifyDriverInterface
    {
        // private PlateInfo innerDriver;
        private List<T_PathIdentifyEquip> CurrentEquipList;

        public bool InitDriver(List<T_PathIdentifyEquip> Equips)
        {
            CurrentEquipList = Equips;
            //innerDriver = new PlateInfo();
            List<PathIdEquip> innerEquipList = new List<PathIdEquip>();
            foreach (T_PathIdentifyEquip e in Equips)
            {
                PathIdEquip item = new PathIdEquip();
                item.equipId = e.Id;
                item.equipType = e.EquipType;
                item.ip = e.Ip;
                item.parentId = e.ParentId;
                item.port = e.Port ?? 8088;
                item.usercode = e.LoginUserName;
                item.password = e.LoginPwd;
                innerEquipList.Add(item);
            }
            bool setStatusEvent = PlateInfo.SetPathIdEquipStatusHandler(OnEquipStatusChanged);
            bool setReceiveEvent = PlateInfo.SetPathIdEquipVehicleInfoHandler(OnVehicleInfoReceived);
            bool initRel = PlateInfo.InitPathIdentificationDriver(innerEquipList);
            //foreach (var item in innerEquipList)
            //{
            //    bool connrel = PlateInfo.Connect(item.parentId);
            //    Debug.Print(connrel.ToString());
            //}
            if (setStatusEvent && setReceiveEvent && initRel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region 回调

        private void OnEquipStatusChanged(PathIdEquipStatusChangedEventArgs args)
        {
            T_PathIdentifyEquip equip = CurrentEquipList.Where(it => it.Id == args.equipId).FirstOrDefault();

            if (args.status == 5)
            {
                PlateInfo.Connect(equip.ParentId);
            }
            if (DeviceStatusNotifyHandler != null)
            {
                if (equip == null)
                {
                    throw new Exception("信路威驱动在回调设备状态时发生错误：未能找到目标设备,EQUIPID=" + args.equipId.ToString());
                }
                DeviceStatus statusInfo = new DeviceStatus();
                statusInfo.Device = equip;
                statusInfo.GatherTime = args.currentDateTime;
                statusInfo.Status = args.status;
                statusInfo.StatusDesc = args.statusDes;
                DeviceStatusNotifyHandler.Invoke(this, statusInfo);
            }
        }

        private void OnVehicleInfoReceived(PathIdEquipVehicleInfoChangedEventArgs args)
        {
            if (VehicleInfoReceiveHandler != null)
            {
                T_PathIdentifyEquip equip = CurrentEquipList.Where(it => it.Id == args.equipId).FirstOrDefault();
                if (equip == null)
                {
                    throw new Exception("信路威驱动在回调车辆通行数据时发生错误：未能找到目标设备,EQUIPID=" + args.equipId.ToString());
                }
                VehicleInfoReceiveEventArgs receiveInfo = new VehicleInfoReceiveEventArgs();
                receiveInfo.CloseShotPhoto = args.imageNear;
                receiveInfo.Device = equip;
                receiveInfo.PanoramaPhoto = args.imageALL;
                receiveInfo.ReachTime = args.reachTime;
                receiveInfo.VehicleLength = args.vehicleLength;
                receiveInfo.VehiclePlateBinPhoto = args.imageBin;
                if (VehiclePlateColorDict.NameColorDict.Keys.Contains(args.vehicleColor))
                {
                    receiveInfo.VehiclePlateColor = args.vehicleColor;
                }
                receiveInfo.VehiclePlateNo = args.vehicleNo;
                receiveInfo.VehiclePlatePhoto = args.imagePlate;
                receiveInfo.VehicleSpeed = args.vehicleSpeed;
                VehicleInfoReceiveHandler.Invoke(this, receiveInfo);
            }
        }

        #endregion 回调

        public bool SetEquipTime(int equipId, DateTime currentTime)
        {
            return PlateInfo.SetEquipTime(equipId, currentTime);
        }

        public bool StopDriver()
        {
            return PlateInfo.StopPathIdentificationDriver();
        }

        public bool Connect(int ParentEquipId)
        {
            return PlateInfo.Connect(ParentEquipId);
        }

        public bool Disconnect(int ParentEquipId)
        {
            return PlateInfo.DisConnect(ParentEquipId);
        }

        public bool GetConnectStatus(int EquipID)
        {
            return PlateInfo.GetConnectStatus(EquipID);
        }

        public EventHandler<DeviceStatus> DeviceStatusNotifyHandler
        {
            get;
            set;
        }

        public EventHandler<VehicleInfoReceiveEventArgs> VehicleInfoReceiveHandler
        {
            get;
            set;
        }

        public bool SetRetransferTime(int equipId, DateTime StartTime, DateTime EndTime)
        {
            T_PathIdentifyEquip equip = CurrentEquipList.Where(it => it.Id == equipId).FirstOrDefault();
            PlateInfo.DisConnect(equip.ParentId);
            return PlateInfo.SetEquipReTranTime(equipId, StartTime, EndTime);
        }
    }
}