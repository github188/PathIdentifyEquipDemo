using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class DAL_ReceiveData
    {
        /// <summary>
        /// 保存接收到的车辆通行数据
        /// </summary>
        /// <param name="data"></param>
        public static void SaveReceiveData(T_ReceiveData data)
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                db.T_ReceiveData.Attach(data);
                db.Entry(data).State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public static T_ReceiveData[] GetAllDatas()
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                return db.T_ReceiveData.ToArray();
            }
        }
    }
}