using ASIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//订单管理
namespace ASIMS.Models.Methods
{
    public class OrderManagement
    {
        /// <summary>
        /// 查询所有订单
        /// </summary>
        /// <returns>订单列表</returns>
        public List<Market> GetAllMarket()
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 查询员工经手的订单
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns>订单列表</returns>
        public List<Market> GetSomeStaffMarket(string id)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 获取员工经手的订单号为no的详细信息
        /// </summary>
        /// <param name="id">员工id</param>
        /// <param name="no">订单号</param>
        /// <returns></returns>
        public Market GetOneStaffMarket(string id, int no)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 查询用户的订单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <returns>订单列表</returns>
        public List<Market> GetSomeUserMarket(string id)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var markets = dbcontext.Market
                    .FromSql("select * from asims.Market")
                    .Where(m => m.Uphone == id)
                    .ToList();
                return markets;
            }
            #endregion
        }
        /// <summary>
        /// 获取用户的订单号为no的详细信息
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="no">订单号</param>
        /// <returns></returns>
        public Market GetOneUserMarket(string id, int no)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var market = dbcontext.Market
                    .Single(m => m.Uphone == id && m.Mno == no);
                try
                {
                    return market;
                }
                catch (Exception)
                {
                    return null;
                }
            }
            #endregion
        }
        /// <summary>
        /// 审核并通过订单，即订单状态置1
        /// </summary>
        /// <param name="no">订单号</param>
        /// <returns>是否成功</returns>
        public bool CheckMarket(int no)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var market = dbcontext.Market
                    .Single(m => m.Mno == no);
                try
                {
                    market.Pflag = 1;
                    return true;
                }
                catch(Exception)
                {
                    return false;
                }
            }
            #endregion
        }

    }
}
