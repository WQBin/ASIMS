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

            #endregion
            return -1;
        }
        /// <summary>
        //根据地址号获取地址
        /// </summary>
        /// <param name="no">地址号</param>
        /// <returns>地址</returns>
        public Address GetOneAddress(int no)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 根据地址号来删除地址
        /// </summary>
        /// <param name="no">地址号</param>
        /// <returns>成功返回true</returns>
        public bool DeleteAddress(int no)
        {
            #region

            #endregion
            return false;
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
