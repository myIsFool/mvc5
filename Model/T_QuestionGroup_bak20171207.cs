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
    
    public partial class T_QuestionGroup_bak20171207
    {
        public int ID { get; set; }
        public byte[] UpdateFlag { get; set; }
        public int QType { get; set; }
        public string STitle { get; set; }
        public string SOption { get; set; }
        public string Answer { get; set; }
        public string Analysis { get; set; }
        public Nullable<int> Difficulty { get; set; }
        public string KenID { get; set; }
        public string Tags { get; set; }
        public int QuestionGroupId { get; set; }
        public Nullable<int> Sort { get; set; }
        public int IState { get; set; }
        public string KenName { get; set; }
        public string TagName { get; set; }
        public Nullable<System.DateTime> OptionTime { get; set; }
        public string VedioUrl { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public Nullable<bool> IsUpdate { get; set; }
    }
}