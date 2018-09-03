using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using  System.Data.Entity;
using ServiceStack.Common;
using  ServiceStack;
using ServiceStack.Redis;
using ServiceStack.Text;
using Newtonsoft.Json;


namespace m5.Dal
{
   public  class User:DbContext
    {

        public bool GetUserChildPackageList(int uid,int state, out List<T_UserPackage> cps, out string error)
        {
            cps=new List<T_UserPackage>();
            error = string.Empty;
            try
            {
                wystuEntities wystu=new wystuEntities();
                var ucs = wystu.T_UserPackage.Where(c => c.userId == uid&&c.isTry==state);
                if (ucs.Any())
                {
                    cps = ucs.ToList();
                    return true;
                }
                else
                {
                    error = "未找到相关数据";
                    return false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// radis设置
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="pwd">用户密码</param>
        /// <param name="qq">qq</param>
        /// <param name="error"></param>
        /// <returns></returns>
        public bool SetUserName(string name,string pwd,string qq,out string error)
        {
            error = string.Empty;
            try
            {
                RedisClient redisClient=new RedisClient();
                T_User uinfo=new T_User();
             
                Random r=new Random();
                int uid = r.Next(0, 1000000000);
                uinfo.ID = uid;
                uinfo.UserName = name;
                uinfo.Password = pwd;
                uinfo.QQ = qq;
                redisClient.Set("u" + uid + "", uinfo);
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
            
        }

        /// <summary>
        /// 根据用户id获取用户信息
        /// </summary>
        /// <param name="uidkey">用户id</param>
        /// <param name="user">用户数据</param>
        /// <param name="error">返回错误信息</param>
        /// <returns></returns>
        public bool GetUserInfo(string uidkey, out T_User user, out string error)
        {
            user=new T_User();
            error = string.Empty;
            try
            {

                RedisClient redisClient=new RedisClient();
                user = redisClient.Get<T_User>(uidkey);
                return true;
            }
            catch (Exception e)
            {
                error = e.Message;
                return false;
            }
        }
    }
}
