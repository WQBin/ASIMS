using ASIMS.Models.Tables;
using Microsoft.EntityFrameworkCore;
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
        /// <returns>车辆列表</returns>未测试
        public List<Vehicle> GetAllVehicle()
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Vehicle
                        .FromSql("select * from asims.Vehicle")
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
        /// 通过id查询汽车
        /// </summary>
        /// <param name="id">汽车id</param>
        /// <returns>汽车</returns>未测试
        public Vehicle CheckVehicleThoughId(int id)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Vehicle
                        .FirstOrDefault(v => v.Vno == id);
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
        /// 通过汽车类型查找汽车
        /// </summary>
        /// <param name="type">汽车类型</param>
        /// <returns>type类型的所有汽车</returns>未测试
        public List<Vehicle> CheckVehicleThoughType(string type)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Vehicle
                        .FromSql("select * from asims.Vehicle")
                        .Where(v => v.Vtype == type)
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
        /// <returns></returns>已测试
        public List<Vehicle> CheckVehicleThoughMore(string type, string Ibran, string Irank, float min, float max)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    List<Vehicle> query = new List<Vehicle>();
                    foreach(var v in dbcontext.Vehicle)
                    {
                        if(v.Vtype==type&&v.Vbrand==Ibran&&v.Virank==Irank&&v.Vprice>=min&&v.Vprice<=max)
                        {
                            query.Add(v);
                        }
                    }
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
        /// 添加车辆到用户购物车
        /// </summary>
        /// <param name="id">用户id</param>
        /// <param name="no">汽车编号</param>
        /// <returns></returns>
        public bool AddVehicleToCart(string id, int no)
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
        public bool DeleteVehicleInCart(string id, int no)
        {
            #region

            #endregion
            return false;
        }
        /// <summary>
        /// 车辆库存查看
        /// </summary>
        /// <param name="vno">车辆编号</param>
        /// <returns></returns>
        public Cashlist GetVehicle(int vno)
        {
            #region
            return null;
            #endregion
        }
        /// <summary>
        /// 车辆库存减num
        /// </summary>
        /// <param name="vno">车辆号</param>
        /// <param name="num">数量</param>
        /// <returns></returns>已测试
        public bool InventoryReduction(int vno,int num)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Cashlist
                        .FirstOrDefault(c => c.Vno == vno);
                    if (query.Vnumber > num)
                    {
                        query.Vnumber = query.Vnumber - num;
                        dbcontext.SaveChanges();
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch
            {
                return false;
            }
            #endregion
        }
        /// <summary>
        /// 进货
        /// </summary>
        /// <param name="vno">车辆编号</param>
        /// <param name="num">车辆数目</param>
        /// <returns></returns>已测试
        public bool StockVehicle(int vno,int num)
        {
            #region
            try
            {
                using (var dbcontext = new asimsContext())
                {
                    var query = dbcontext.Cashlist
                        .FirstOrDefault(c => c.Vno == vno);
                    query.Vnumber = query.Vnumber+num;
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
        /// 车辆信息修改
        /// </summary>
        /// <param name="vno">车辆号</param>
        /// <param name="vehicle">车辆新信息</param>
        /// <returns></returns>
        public bool ModifyVehicleInfor(int vno,Vehicle vehicle)
        {
            #region
            return false;
            #endregion
        }
        /// <summary>
        /// 退货
        /// </summary>
        /// <param name="vno">车辆编号</param>
        /// <param name="num">车辆数目</param>
        /// <param name="sno">供货商号</param>
        /// <returns></returns>
        public bool SalesReturnVehicle(int vno,int num,int sno)
        {
            #region
            return false; 
            #endregion
        }
        /// <summary>
        /// 添加供货商
        /// </summary>
        /// <param name="suppler"></param>
        /// <returns></returns>
        public bool AddSupplier(Suppler suppler)
        {
            #region
            return false;
            #endregion
        }
    }
}
