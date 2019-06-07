using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASIMS.Models.Method;
using ASIMS.Models.Methods;
using ASIMS.Models.Tables;
using Microsoft.AspNetCore.Mvc;

namespace ASIMS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            UserManagement method = new UserManagement();
            List<User> users = method.ListAllUser();
            VehicleManagement vehicle = new VehicleManagement();
            vehicle.CheckVehicleThoughMore("皮卡", "福特", "皮卡", 25, 52);
            //vehicle.StockVehicle(2, 5);
            vehicle.InventoryReduction(2, 15);
            return View();
        }
    }
}