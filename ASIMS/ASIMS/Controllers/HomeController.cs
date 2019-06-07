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
            
            return View();
        }
    }
}