using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DataDict.Dicts
{
    /// <summary>
    /// 车牌颜色字典
    /// </summary>
    public static class VehiclePlateColorDict
    {
        static VehiclePlateColorDict()
        {
            NameColorDict.Add("蓝", Color.Blue);
            NameColorDict.Add("黄", Color.Yellow);
            NameColorDict.Add("白", Color.White);
            NameColorDict.Add("黑", Color.Black);
        }

        public static Dictionary<string, Color> NameColorDict = new Dictionary<string, Color>();
    }
}