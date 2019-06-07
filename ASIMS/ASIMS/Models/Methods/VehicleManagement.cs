using ASIMS.Models.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//汽车管理
namespace ASIMS.Models.Methods
{
    public class VehicleManagement
    {
        /// <summary>
        /// 获取所有车辆
        /// </summary>
        /// <returns>车辆列表</returns>
        public List<Vehicle> GetAllVehicle()
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 通过id查询汽车
        /// </summary>
        /// <param name="id">汽车id</param>
        /// <returns>汽车</returns>
        public Vehicle CheckVehicleThoughId(int id)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 通过汽车类型查找汽车
        /// </summary>
        /// <param name="type">汽车类型</param>
        /// <returns>type类型的所有汽车</returns>
        public List<Vehicle> CheckVehicleThoughType(string type)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 通过汽车名称进行模糊查询
        /// </summary>
        /// <param name="name">汽车名或部分汽车名</param>
        /// <returns>包含name的所有汽车</returns>
        public List<Vehicle> CheckVehicleThoughName(string name)
        {
            #region
            //SELECT * from vehicle 
            //where Vname like '宝马%';
            #endregion
            return null;
        }
        /// <summary>
        //复合条件查询车辆
        /// </summary>
        /// <param name="type">车辆类型</param>
        /// <param name="Ibran">车辆品牌</param>
        /// <param name="Irank">车辆级别</param>
        /// <param name="min">最低价格</param>
        /// <param name="max">最高价格</param>
        /// <returns></returns>
        public List<Vehicle> CheckVehicleThoughMore(string type,string Ibran,string Irank,float min,float max)
        {
            #region

            #endregion
            return null;
        }
        /// <summary>
        /// 添加车辆到用户购物车
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="no">汽车编号</param>
        /// <returns></returns>
        public bool AddVehicleToCart(string id,int no)
        {
            #region

            #endregion
            return false;
        }
        /// <summary>
        /// 删除用户购物车中的车辆号为no的车辆
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="no">车辆号</param>
        /// <returns></returns>
        public bool DeleteVehicleInCart(string id,int no)
        {
            #region

            #endregion
            return false;
        }

        

    }
}
