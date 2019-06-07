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
        /// <returns>订单列表</returns>未测试
        public List<Market> GetAllMarket()
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Market
                        .FromSql("select * from asims.Market")
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
        /// 查询员工经手的订单
        /// </summary>
        /// <param name="id">员工id</param>
        /// <returns>订单列表</returns>未测试
        public List<Market> GetSomeStaffMarket(string id)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Market
                        .FromSql("select * from asims.Market")
                        .Where(m => m.Sphone == id)
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
        /// 获取员工经手的订单号为no的详细信息
        /// </summary>
        /// <param name="id">员工id</param>
        /// <param name="no">订单号</param>
        /// <returns></returns>未测试
        public Market GetOneStaffMarket(string id, int no)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Market
                        .FirstOrDefault(m => m.Sphone == id && m.Mno == no);
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
        /// <returns></returns>未测试
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
        /// 审核并通过订单，即订单状态置1,且库存减1
        /// </summary>
        /// <param name="no">订单号</param>
        /// <param name="id">销售人员id</param>
        /// <returns></returns>未测试
        public bool CheckMarket(int no,string id)
        {
            #region
            using (var dbcontext = new asimsContext())
            {
                var market = dbcontext.Market
                    .Single(m => m.Mno == no);
                try
                {
                    market.Pflag = 1;
                    market.Sphone = id;
                    VehicleManagement vehicle = new VehicleManagement();
                    bool isSuccess = vehicle.InventoryReduction((int)market.Vno, (int)market.Number);
                    if (isSuccess)
                    {
                        dbcontext.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            #endregion
        }
        /// <summary>
        /// 提交订单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="market">订单</param>
        /// <returns></returns>未测试
        public bool SubmitOrder(string id,Market market)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    market.Uphone = id;
                    dbcontext.Add(market);
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
        /// 用户退单
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="mno">单号</param>
        /// <returns></returns>未测试
        public bool UserChargeBack(string id, int mno)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Market
                        .FirstOrDefault(m => m.Sphone == id && m.Mno == mno);
                    dbcontext.Remove(query);
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
