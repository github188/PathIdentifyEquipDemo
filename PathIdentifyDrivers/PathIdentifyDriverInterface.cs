using DAL;
using DataDict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathIdentifyDrivers
{
    public interface PathIdentifyDriverInterface
    {
        /// <summary>
        /// 设备状态回调句柄
        /// </summary>
        EventHandler<DeviceStatus> DeviceStatusNotifyHandler
        { get; set; }

        /// <summary>
        /// 车辆数据回调句柄
        /// </summary>
        EventHandler<VehicleInfoReceiveEventArgs> VehicleInfoReceiveHandler
        { get; set; }

        /// <summary>
        /// 初始化驱动
        /// </summary>
        /// <param name="Equips"></param>
        /// <returns></returns>
        bool InitDriver(List<T_PathIdentifyEquip> Equips);

        /// <summary>
        /// 连接设备，按设备组连接
        /// </summary>
        /// <param name="ParentEquipId"></param>
        /// <returns></returns>
        bool Connect(int ParentEquipId);

        /// <summary>
        /// 断开设备连接，按设备组断开
        /// </summary>
        /// <param name="ParentEquipId"></param>
        /// <returns></returns>
        bool Disconnect(int ParentEquipId);

        /// <summary>
        /// 获取当前设备连接状态
        /// </summary>
        /// <param name="EquipID"></param>
        /// <returns></returns>
        bool GetConnectStatus(int EquipID);

        /// <summary>
        /// 设备校时
        /// </summary>
        /// <param name="equipId"></param>
        /// <param name="currentTime"></param>
        /// <returns></returns>
        bool SetEquipTime(int equipId, DateTime currentTime);

        /// <summary>
        /// 停止驱动程序
        /// </summary>
        /// <returns></returns>
        bool StopDriver();
    }
}