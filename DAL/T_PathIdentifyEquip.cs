//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_PathIdentifyEquip
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string EquipName { get; set; }
        public string Ip { get; set; }
        public Nullable<int> Port { get; set; }
        public int ProtocolId { get; set; }
        public int EquipType { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Mile { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPwd { get; set; }
    }
}
