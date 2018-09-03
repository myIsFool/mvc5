using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using ServiceStack.Redis;

namespace SystemTask
{
    public class SystemData:MultiThread<SystemData>
    {
        static readonly Log Log = new Log("SystemData");

        static SystemData()
        {
            AddTask(SetPackages, 6000);
            AddTask(SetChildPackages,6000);
        }

        /// <summary>
        /// 获取数据库中所有套餐列表赋值与内存中
        /// </summary>
        private static void SetPackages()
        {   
            wystuEntities wystu=new wystuEntities();
            var packageList = wystu.T_Package;
            RedisClient rc=new RedisClient();
            if (packageList.Any())
            {
                rc.Set("pks", packageList);
            }
        }
        /// <summary>
        /// 获取子套餐
        /// </summary>
        private static void SetChildPackages()
        {   
            wystuEntities wystu=new wystuEntities();
            var cps = wystu.T_ChildPackage.Where(c => c.Status == 1);
            if (cps.Any())
            {
                RedisClient rc=new RedisClient();
                rc.Set("cps", cps);
            }
        }

        private static void SetCourse()
        {   
            wystuEntities wystu=new wystuEntities();
            var courses = from c1 in wystu.T_Course
                join pls in wystu.T_Plate on c1.ID equals pls.CID
                select new {cid = c1.ID, cname = c1.Name, ctype = c1.CourseType,cimg=c1.CourseImg,pid=pls.ID,pname=pls.Name,ptype=pls.Type,pioc=pls.ico};
            if (courses.Any())
            {
                List<CoursePlate> coursePlates=new List<CoursePlate>();
                List<T_Plate> tps=new List<T_Plate>();
                List<int> cids= new List<int>();
                foreach (var item in courses)
                {
                    if (!cids.Contains(item.cid))
                    {
                        CoursePlate cp=new CoursePlate();
                        cp.Id = item.cid;
                        cp.Ctype = Convert.ToInt32(item.ctype);
                        cp.Cimage = item.cimg;
                        cp.Name = item.cname;
                        cp.Plates= new List<T_Plate>();
                        coursePlates.Add(cp);
                    }
                    T_Plate tp= new T_Plate();
                    tp.ID = item.pid;
                    tp.CID = item.cid;
                    tp.Name = item.pname;
                    tp.Type = item.ptype;
                    tp.ico = item.pioc;
                    tps.Add(tp);
                    coursePlates.Where(c=>c.Id==item.pid).FirstOrDefault().Plates.Add(tp);
                }

            }
        }

    }
}
