//管理员及销售人员信息管理模块
//已全部完成
using ASIMS.Models;
using ASIMS.Models.Tables;
using System.Linq;

namespace AdminInfor
{
    class AdminInforManagement
    {
        /// <summary>
        /// 处理员工的登录请求
        /// </summary>
        /// <param name="id">员工id</param>
        /// <param name="password">员工密码</param>
        /// <returns>成功返回true</returns>未测试
        public bool Login(string id, string password)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var staff = dbcontext.Staff
                    .FirstOrDefault(s => s.Sphone == id && s.Spassword == password);
                if (staff != null)
                    return true;
            }
            #endregion
            return false;
        }
        /// <summary>
        //更新员工密码
        /// </summary>
        /// <param name="id">员工id</param>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="newPassword">新密码</param>
        /// <returns>成功返回true</returns>未测试
        public bool NewPassword(string id, string oldPassword, string newPassword)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                foreach (var staff in dbcontext.Staff)
                {
                    if (staff.Sphone == id && staff.Spassword == oldPassword)
                    {
                        staff.Spassword = newPassword;
                        dbcontext.SaveChanges();
                        break;
                    }
                }
            }
            #endregion
            return false;
        }
        /// <summary>
        //更改员工信息
        /// </summary>
        /// <param name="id">员工id</param>
        /// <param name="staff">新员工信息</param>
        /// <param name="address">员工地址号</param>
        /// <returns></returns>未测试
        public bool ModifyInformation(string id, Staff staff, int address)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var staffs = dbcontext.Staff
                    .Single(staf => staf.Sphone == id);
                if (staffs != null)
                {
                    staffs = staff;
                    staff.Saddress = address;
                    dbcontext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            #endregion
        }

    }

}



