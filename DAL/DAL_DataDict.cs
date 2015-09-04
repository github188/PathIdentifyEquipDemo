using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class DAL_DataDict
    {
        public static List<T_DataDict> GetAllDataDict()
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                return db.T_DataDict.ToList();
            }
        }
    }
}