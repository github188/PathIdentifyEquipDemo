using DAL;
using DataDict.Dicts;
using DataDict.Models;
using HWTC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathIdentifyDrivers
{
    /// <summary>
    /// 汉王抓拍设备驱动
    /// </summary>
    public class HanvonDriver : PathIdentifyDriverInterface
    {
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

        private HanWangPathIdDriver innerDriver;

        private List<T_PathIdentifyEquip> CurrentEquipList;

        public bool InitDriver(List<T_PathIdentifyEquip> Equips)
        {
            CurrentEquipList = Equips;
            innerDriver = new HanWangPathIdDriver();
            List<PathIdEquip> innerEquipList = new List<PathIdEquip>();
            foreach (T_PathIdentifyEquip e in Equips)
            {
                PathIdEquip item = new PathIdEquip();
                item.equipId = e.Id;
                item.equipType = e.EquipType;
                item.ip = e.Ip;
                item.parentId = e.ParentId;
                item.port = e.Port ?? 8088;
                innerEquipList.Add(item);
            }

            bool setStatusEvent = innerDriver.SetPathIdEquipStatusHandler(OnEquipStatusChanged);
            bool setReceiveEvent = innerDriver.SetPathIdEquipVehicleInfoHandler(OnVehicleInfoReceived);
            bool initRel = innerDriver.InitPathIdentificationDriver(innerEquipList);
            if (setStatusEvent && setReceiveEvent && initRel)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Connect(int ParentEquipId)
        {
            return innerDriver.Connect(ParentEquipId);
        }

        public bool Disconnect(int ParentEquipId)
        {
            return innerDriver.DisConnect(ParentEquipId);
        }

        public bool GetConnectStatus(int EquipID)
        {
            return innerDriver.GetConnectStatus(EquipID);
        }

        public bool SetEquipTime(int equipId, DateTime currentTime)
        {
            return innerDriver.SetEquipTime(equipId, currentTime);
        }

        public bool StopDriver()
        {
            return innerDriver.StopPathIdentificationDriver();
        }

        public bool SetRetransferTime(int equipId, DateTime StartTime, DateTime EndTime)
        {
            return innerDriver.SetEquipReTranTime(equipId, StartTime, EndTime);
        }

        #region 回调

        private void OnEquipStatusChanged(object sender, PathIdEquipStatusChangedEventArgs args)
        {
            if (DeviceStatusNotifyHandler != null)
            {
                T_PathIdentifyEquip equip = CurrentEquipList.Where(it => it.Id == args.StatusInfo.equipId).FirstOrDefault();
                if (equip == null)
                {
                    throw new Exception("汉王驱动在回调设备状态时发生错误：未能找到目标设备,EQUIPID=" + args.StatusInfo.equipId.ToString());
                }
                DeviceStatus statusInfo = new DeviceStatus();
                statusInfo.Device = equip;
                statusInfo.GatherTime = args.StatusInfo.currentDateTime;
                statusInfo.Status = args.StatusInfo.status;
                statusInfo.StatusDesc = args.StatusInfo.statusDes;
                DeviceStatusNotifyHandler.Invoke(this, statusInfo);
            }
        }

        private void OnVehicleInfoReceived(object sender, PathIdEquipVehicleInfoChangedEventArgs args)
        {
            if (VehicleInfoReceiveHandler != null)
            {
                T_PathIdentifyEquip equip = CurrentEquipList.Where(it => it.Id == args.VehicleInfo.equipId).FirstOrDefault();
                if (equip == null)
                {
                    throw new Exception("汉王驱动在回调车辆通行数据时发生错误：未能找到目标设备,EQUIPID=" + args.VehicleInfo.equipId.ToString());
                }
                VehicleInfoReceiveEventArgs receiveInfo = new VehicleInfoReceiveEventArgs();
                receiveInfo.CloseShotPhoto = args.VehicleInfo.imageNear;
                receiveInfo.Device = equip;
                receiveInfo.PanoramaPhoto = args.VehicleInfo.imageAll;
                receiveInfo.ReachTime = args.VehicleInfo.reachTime;
                receiveInfo.VehicleLength = args.VehicleInfo.vehicleLength;
                receiveInfo.VehiclePlateBinPhoto = args.VehicleInfo.imageBin;
                if (VehiclePlateColorDict.NameColorDict.Keys.Contains(args.VehicleInfo.vehicleColor))
                {
                    receiveInfo.VehiclePlateColor = args.VehicleInfo.vehicleColor;
                }
                receiveInfo.VehiclePlateNo = args.VehicleInfo.vehicleNo;
                receiveInfo.VehiclePlatePhoto = args.VehicleInfo.imagePlate;
                receiveInfo.VehicleSpeed = args.VehicleInfo.vehicleSpeed;
                VehicleInfoReceiveHandler.Invoke(this, receiveInfo);
            }
        }

        #endregion 回调
    }
}