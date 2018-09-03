using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public partial class CoursePlate
   {
       /// <summary>
       /// 课程id
       /// </summary>
       private int _id;
       /// <summary>
       /// 课程名称
       /// </summary>
       private string _name;
       /// <summary>
       /// 任务总数
       /// </summary>
       private int _tcount;
       /// <summary>
       /// 课程类型(0标准类型，1视频课程)
       /// </summary>
       private int _ctype;
       /// <summary>
       /// 课程图片(若是视频课程)
       /// </summary>
       private string _cimage;
       /// <summary>
       /// 课程板块
       /// </summary>
       private List<T_Plate> _plates;


       /// <summary>
       /// 课程id
       /// </summary>
       public int Id
       {
           get { return _id; }
           set { _id = value; }
       }

       /// <summary>
       /// 课程名称
       /// </summary>
       public string Name
       {
           get { return _name; }
           set { _name = value; }
       }

       /// <summary>
       /// 任务总数
       /// </summary>
       public int Tcount
       {
           get { return _tcount; }
           set { _tcount = value; }
       }

       /// <summary>
       /// 课程类型(0标准类型，1视频课程)
       /// </summary>
       public int Ctype
       {
           get { return _ctype; }
           set { _ctype = value; }
       }

       /// <summary>
       /// 课程图片(若是视频课程)
       /// </summary>
       public string Cimage
       {
           get { return _cimage; }
           set { _cimage = value; }
       }

       /// <summary>
       /// 课程板块
       /// </summary>
       public List<T_Plate> Plates
       {
           get { return _plates; }
           set { _plates = value; }
       }
   }
}
