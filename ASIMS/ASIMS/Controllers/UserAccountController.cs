using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASIMS.Models;
using ASIMS.Models.Method;
using ASIMS.Models.Methods;

namespace ASIMS.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password)
        {
            UserInforManagement function = new UserInforManagement();
            bool isTure = function.Login(username, password);
            if (!isTure)
            {
                var message = "登录失败，请核对账号和密码！";
                ViewBag.message = message;
                return View();
            }
            else
                return RedirectToAction("Index", "Home");

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
