using ASIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
/// <summary>
/// 用户管理模块，实现的功能有，
/// 1.列出所有的用户
/// 2.查看某一用户的详细信息
/// 已全部完成
/// </summary>
namespace ASIMS.Models.Method
{
    public class UserManagement
    {
        /// <summary>
        /// 查看所有用户
        /// </summary>
        /// <returns>所有用户</returns>
        public List<User> ListAllUser()
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var query = dbcontext.User.FromSql("select * from asims.User").ToList();
                return query;
            }
            #endregion
            
        }
        /// <summary>
        /// 查看账号为id用户的详细信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>账号为id的用户</returns>
        public User GetUserDetail(string id)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var user = dbcontext.User
                    .Single(users => users.Uphone == id);
                return user;
            }
            #endregion
        }
    }
}
