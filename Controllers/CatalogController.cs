using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using erp.Models;

namespace erp.Controllers
{

    public class CatalogController : Controller
    {
        //  /catalog/index
        // /catalog
        public IActionResult Index()
        {
            return View();
        }

        // /catalog/register
        public IActionResult Register()
        {
            return View();
        }

    }

}