using ASIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//地址管理
namespace ASIMS.Models.Methods
{
    public class AddressManagement
    {
        /// <summary>
        /// 插入地址
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns>地址编号</returns>
        public int InsertAddress(Address address)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    dbcontext.Add(address);
                    return address.Ano;
                }
            }
            catch
            {
                return -1;
            }
            #endregion
        }
        /// <summary>
        //根据地址号获取地址
        /// </summary>
        /// <param name="no">地址号</param>
        /// <returns>地址</returns>
        public Address GetOneAddress(int no)
        {
            #region
            try
            {
                using (var db = new asimsContext())
                {
                    return db.Find<Address>(no);
                }
            }
            catch
            {
                return null;
            }
            #endregion
        }
        /// <summary>
        /// 根据地址号来删除地址
        /// </summary>
        /// <param name="no">地址号</param>
        /// <returns>成功返回true</returns>
        public bool DeleteAddress(int no)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    dbcontext.Remove<Address>(this.GetOneAddress(no));
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
        /// 修改地址信息
        /// </summary>
        /// <param name="no">地址号</param>
        /// <param name="address">新地址</param>
        /// <returns></returns>
        public bool ModifyAddress(string no,Address address)
        {
            #region

            #endregion
            return false;
        }
    }
}
