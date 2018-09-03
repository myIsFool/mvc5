using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using m5.Bll;
using Model;

namespace m5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int uid = 2002400321;
            int state = 0;
            UserBll ub= new UserBll();
            string error = string.Empty;
            List<T_UserPackage> up=new List<T_UserPackage>();

            if (ub.GetUserChildPackageList(uid,state,out up,out error))
            {
                ViewBag.Data = up;
                ViewBag.State = true;
            }
            else
            {
                ViewBag.State = false;
            }

            string uname = "尹美林";
            string pwd = "123456";
            string qq = "654579635";
            if (ub.SetUserName(uname,pwd,qq,out error))
            {
                T_User user=new T_User();
                string ukey = "";
                if (ub.GetUserInfo(ukey,out user,out error))
                {
                    ViewBag.UserInfo = user;
                }
            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}