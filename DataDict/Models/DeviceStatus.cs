using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataDict.Models
{
    /// <summary>
    /// 设备状态属性集合
    /// </summary>
    public class DeviceStatus : EventArgs
    {
        /// <summary>
        /// 设备
        /// </summary>
        public T_PathIdentifyEquip Device
        { get; set; }

        /// <summary>
        /// 状态枚举值
        /// </summary>
        public int Status
        { get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        public string StatusDesc
        { get; set; }

        /// <summary>
        /// 采集时间
        /// </summary>
        public DateTime GatherTime
        { get; set; }
    }
}