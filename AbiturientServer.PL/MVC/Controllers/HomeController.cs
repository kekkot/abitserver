using AbiturientServer.DAL;
using AbiturientServer.DAL.EF;
using AbiturientServer.DAL.Entities;
using AbiturientServer.DAL.Interfaces;
using AbiturientServer.PL.MVC.ViewModels.Error;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AbiturientServer.PL.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUnitOfWork _context;
        private DbInitializer _initializer;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork context, DbInitializer initializer)
        {
            _logger = logger;
            _context = context;
            _initializer = initializer;
        }

        public IActionResult Index()
        {
            //_initializer.Initialize();
            return View("~/MVC/Views/Home/Index.cshtml");
        }

        public IActionResult Privacy()
        {
            return View("~/MVC/Views/Home/Privacy.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("~/MVC/Views/Shared/Error.cshtml", new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
