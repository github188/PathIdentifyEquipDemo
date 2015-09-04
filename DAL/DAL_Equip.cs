using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class DAL_Equip
    {
        public static List<T_PathIdentifyEquip> GetAllPathIdEquip()
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                return db.T_PathIdentifyEquip.ToList();
            }
        }
    }
}