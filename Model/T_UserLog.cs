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
    
    public partial class T_UserLog
    {
        public int Id { get; set; }
        public byte[] UpdateFlag { get; set; }
        public int AppId { get; set; }
        public Nullable<System.DateTime> InitTime { get; set; }
        public long UserId { get; set; }
        public string UserName { get; set; }
        public Nullable<int> TypeId { get; set; }
        public string ModelName { get; set; }
        public string Memo { get; set; }
        public string Ip { get; set; }
        public string Area { get; set; }
        public string KeyCode { get; set; }
    }
}
