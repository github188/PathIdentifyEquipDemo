using DAL;
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

        public bool InitDriver(List<T_PathIdentifyEquip> Equips)
        {
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
            return innerDriver.InitPathIdentificationDriver(innerEquipList);
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
            return innerDriver.SetEquipReTranTime(equipId, StartTime);
        }
    }
}