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
    
    public partial class T_UserPackage_copy
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int packageId { get; set; }
        public string userName { get; set; }
        public string packageName { get; set; }
        public Nullable<double> packagePrice { get; set; }
        public Nullable<System.DateTime> buyDate { get; set; }
        public Nullable<System.DateTime> expiresDate { get; set; }
        public Nullable<int> expriesType { get; set; }
        public Nullable<int> isTry { get; set; }
        public Nullable<int> CourseCount { get; set; }
        public string packageImg { get; set; }
        public Nullable<System.DateTime> settingTime { get; set; }
    }
}