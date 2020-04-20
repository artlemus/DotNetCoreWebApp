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

    public class MessageController : Controller {

        public IActionResult SayHello(){
            return View();
        }

       


    }

    
}