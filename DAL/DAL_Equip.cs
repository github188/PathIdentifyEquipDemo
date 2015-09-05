using System;
using System.Collections.Generic;
using System.Data;
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

        public static void SaveOrModifyEquip(T_PathIdentifyEquip equip)
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                //if (equip.CreateTime == null)
                //    equip.CreateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                //        , DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
                db.T_PathIdentifyEquip.Attach(equip);
                if (equip.Id <= 0)
                {
                    db.Entry(equip).State = EntityState.Added;
                }
                else
                {
                    db.Entry(equip).State = EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        public static void DelEquip(T_PathIdentifyEquip equip)
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                db.T_PathIdentifyEquip.Attach(equip);
                db.Entry(equip).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}