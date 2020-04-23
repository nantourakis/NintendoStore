using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NintendoStore.Controllers
{
    public class ContactController : Controller
    {
        // Created View is name of the action..Index
        public IActionResult Index()
        {
            return View();
        }
    }
}
