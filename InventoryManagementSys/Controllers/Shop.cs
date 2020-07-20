using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSys.Controllers
{
    public class Shop : Controller
    {
        [Authorize(Roles = "Shop")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
