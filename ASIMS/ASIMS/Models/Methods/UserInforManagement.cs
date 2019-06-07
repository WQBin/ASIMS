using ASIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//用户信息管理
namespace ASIMS.Models.Methods
{
    public class UserInforManagement
    {
        /// <summary>
        /// 处理用户的注册
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <param name="address">地址号</param>
        /// <returns></returns>未测试
        public bool Register(User user, int address)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    user.Uaddress = address;
                    dbcontext.User.Add(user);
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            #endregion
        }
        /// <summary>
        /// 处理用户的登录请求
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="password">用户密码</param>
        /// <returns></returns>已测试
        public bool Login(string id, string password)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var user = dbcontext.User
                    .FirstOrDefault(u => u.Uphone == id && u.Upassword == password);
                if (user != null)
                    return true;
                else
                    return false;
            }
            #endregion
        }
        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="id"></param>
        /// <param name="oldPassword"></param>
        /// <param name="newPassword"></param>
        /// <returns></returns>已测试
        public bool NewPassword(string id, string oldPassword, string newPassword)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var user = dbcontext.User
                       .FirstOrDefault(u => u.Uphone == id && u.Upassword == oldPassword);
                if (user != null)
                {
                    user.Upassword = newPassword;
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            #endregion
        }
        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="user">用户对象</param>
        /// <param name="address">地址编号</param>
        /// <returns></returns>未测试
        public bool ModifyInformation(string id, User user, int address)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.User
                        .FirstOrDefault(u => u.Uphone == id);
                    query = user;
                    query.Uaddress = address;
                    dbcontext.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
            #endregion
        }
    }
}
