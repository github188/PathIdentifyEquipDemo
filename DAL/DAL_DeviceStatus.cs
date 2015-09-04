using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public static class DAL_DeviceStatus
    {
        /// <summary>
        /// 保存设备状态数据
        /// </summary>
        /// <param name="status"></param>
        public static void SaveDeviceStatus(T_DeviceStatusLog status)
        {
            using (PathIdentifyEquipDemoDBEntities db = new PathIdentifyEquipDemoDBEntities())
            {
                db.T_DeviceStatusLog.Attach(status);
                db.Entry(status).State = EntityState.Added;
                db.SaveChanges();
            }
        }
    }
}