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
    
    public partial class P_AppAdd_Result
    {
        public int Id { get; set; }
        public byte[] UpdateFlag { get; set; }
        public Nullable<int> AdminId { get; set; }
        public string Code { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Name { get; set; }
        public string Secret { get; set; }
        public int TypeId { get; set; }
        public Nullable<bool> Enable { get; set; }
        public Nullable<bool> IsAllowReg { get; set; }
    }
}
