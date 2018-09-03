using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using m5.Dal;
using Model;

namespace m5.Bll
{
    public class UserBll
    {
        public bool GetUserChildPackageList(int uid,int state, out List<T_UserPackage> cps, out string error)
        {
            User u=new User();
            return u.GetUserChildPackageList(uid,state, out cps, out error);
        }

        public bool SetUserName(string name, string pwd, string qq, out string error)
        {
            User u=new User();
            return u.SetUserName(name, pwd, qq, out error);
        }

        public bool GetUserInfo(string uidkey, out T_User user, out string error)
        {
           User u=new User();
            return u.GetUserInfo(uidkey, out user, out error);
        }
    }
}
