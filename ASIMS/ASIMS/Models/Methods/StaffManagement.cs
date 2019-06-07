using ASIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASIMS.Models.Methods
{
    public class StaffManagement
    {
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="staff">员工</param>
        /// <returns></returns>未测试
        public bool AddStaff(Staff staff)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    dbcontext.Add(staff);
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
        /// 删除员工
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>未测试
        public bool DeleteStaff(string id)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = GetStaffThoughID(id);
                    dbcontext.Staff.Remove(query);
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
        /// 通过id获取员工
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns></returns>未测试
        public Staff GetStaffThoughID(string id)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Staff
                        .FirstOrDefault(s => s.Sphone == id);
                    return query;
                }
            }
            catch
            {
                return null;
            }
            #endregion
        }
        /// <summary>
        /// 通过姓名获取员工（模糊查找）
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <returns></returns>已测试
        public List<Staff> GetStaffThoughName(string name)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Staff
                        .Where(s => s.Sname.Contains(name))
                        .ToList();
                    return query;
                }
            }
            catch
            {
                return null;
            }
            #endregion
        }
        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>未测试
        public List<Staff> GetAllStaff()
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Staff
                        .FromSql("select * from asims.Staff")
                        .ToList();
                    return query;
                }
            }
            catch
            {
                return null;
            }
            #endregion
        }
        /// <summary>
        /// 提升员工权限
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns></returns>未测试
        public bool UpdateStaffLevel(string id)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Staff
                        .FirstOrDefault(s => s.Sphone == id);
                    query.Stype = "管理员";
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