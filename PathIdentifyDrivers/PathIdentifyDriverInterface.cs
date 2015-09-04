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