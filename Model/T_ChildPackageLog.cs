//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_ChildPackageLog
    {
        public int ID { get; set; }
        public int PId { get; set; }
        public string Name { get; set; }
        public string UpName { get; set; }
        public Nullable<System.DateTime> InitTime { get; set; }
        public Nullable<double> PersonalPrice { get; set; }
        public Nullable<double> UPPersonalPrice { get; set; }
        public Nullable<double> GroupPrice { get; set; }
        public Nullable<double> UpGroupPrice { get; set; }
        public string PlateStr { get; set; }
        public string UpPlateStr { get; set; }
        public string Version { get; set; }
        public string UpVersion { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string Memo { get; set; }
        public Nullable<int> OperUserId { get; set; }
        public string OperName { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
