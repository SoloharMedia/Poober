using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Poober.Controllers
{
    public class PooperController : Controller
    {
        public string cs = "Server=(localdb)\\mssqllocaldb;Database=PooberNewDb;Trusted_Connection=True;ConnectRetryCount=0";

        public IActionResult Index()
        {
            return View();
        }
    }
}