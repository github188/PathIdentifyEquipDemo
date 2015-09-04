using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DataDict.Models
{
    /// <summary>
    /// 抓拍回调信息
    /// </summary>
    public class VehicleInfoReceiveEventArgs : EventArgs
    {
        /// <summary>
        /// 当前回调的设备
        /// </summary>
        public T_PathIdentifyEquip Device
        { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        public string VehiclePlateNo
        { get; set; }

        /// <summary>
        /// 车牌颜色
        /// </summary>
        public string VehiclePlateColor
        { get; set; }

        /// <summary>
        /// 车速(km/h)
        /// </summary>
        public int VehicleSpeed
        { get; set; }

        /// <summary>
        /// 到达时间
        /// </summary>
        public DateTime ReachTime
        { get; set; }

        /// <summary>
        /// 全景图
        /// </summary>
        public byte[] PanoramaPhoto
        { get; set; }

        /// <summary>
        /// 近景图
        /// </summary>
        public byte[] CloseShotPhoto
        { get; set; }

        /// <summary>
        /// 车牌图
        /// </summary>
        public byte[] VehiclePlatePhoto
        { get; set; }

        /// <summary>
        /// 车牌二值化图
        /// </summary>
        public byte[] VehiclePlateBinPhoto
        { get; set; }

        /// <summary>
        /// 车辆长度(m)
        /// </summary>
        public float VehicleLength
        { get; set; }
    }
}