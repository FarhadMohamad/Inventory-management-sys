using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagementSys.Controllers
{
    public class Warehouse : Controller
    {
        [Authorize (Roles = "Warehouse")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
