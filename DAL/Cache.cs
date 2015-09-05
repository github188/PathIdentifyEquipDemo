using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class Cache
    {
        /// <summary>
        /// 抓拍设备缓存
        /// </summary>
        public static List<T_PathIdentifyEquip> PathIdEquips
        { get; set; }

        public static List<T_DataDict> DataDictCache
        { get; set; }

        /// <summary>
        /// 初始化缓存
        /// </summary>
        public static void Init()
        {
            PathIdEquips = DAL_Equip.GetAllPathIdEquip();
            DataDictCache = DAL_DataDict.GetAllDataDict();
        }

        public static void InitAllPathIdEquip()
        {
            PathIdEquips = DAL_Equip.GetAllPathIdEquip();
        }

        public static void RemoveEquip(T_PathIdentifyEquip equip)
        {
            DAL_Equip.DelEquip(equip);
            PathIdEquips.Remove(equip);
        }
    }
}