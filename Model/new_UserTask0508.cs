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
    
    public partial class new_UserTask0508
    {
        public int id { get; set; }
        public int userId { get; set; }
        public int taskId { get; set; }
        public string taskname { get; set; }
        public Nullable<int> taskType { get; set; }
        public Nullable<int> parentPlate { get; set; }
        public Nullable<int> packageId { get; set; }
        public Nullable<int> courseId { get; set; }
        public Nullable<int> ifFree { get; set; }
        public Nullable<int> isUnlock { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string completeQId { get; set; }
        public string rightQid { get; set; }
        public Nullable<int> qCount { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> lastOptionTime { get; set; }
        public string userAnswer { get; set; }
        public Nullable<double> score { get; set; }
        public Nullable<int> shareed { get; set; }
        public Nullable<int> countdown { get; set; }
        public Nullable<double> bestScore { get; set; }
        public int correctSmallSubject { get; set; }
        public int errorSmallSubject { get; set; }
        public int emptySmallSubject { get; set; }
        public string bigSubject { get; set; }
        public Nullable<int> standardQcount { get; set; }
    }
}