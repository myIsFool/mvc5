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
    
    public partial class T_Paper
    {
        public int ID { get; set; }
        public byte[] UpdateFlag { get; set; }
        public string Name { get; set; }
        public double TimeSpan { get; set; }
        public int Sort { get; set; }
        public byte Status { get; set; }
        public Nullable<int> PaperSchemaID { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string Dif { get; set; }
        public Nullable<int> SyllabusID { get; set; }
        public bool IsAuto { get; set; }
        public string QuestionDetail { get; set; }
        public Nullable<int> Qcount { get; set; }
        public Nullable<double> Score { get; set; }
        public string QIds { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string CreateUser { get; set; }
        public string UpdateUser { get; set; }
        public string ExamineUser { get; set; }
        public Nullable<System.DateTime> ExamineTime { get; set; }
    }
}
