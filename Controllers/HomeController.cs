using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4_Elections.Models;
using Assignment4_Elections.APIHandlerManager;

namespace Assignment4_Elections.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Created By";

            return View();
        }

        public IActionResult Candidates()
        {
            APIHandler webHandler = new APIHandler();
            Candidates candidates = webHandler.GetCandidates();
            return View(candidates);
            
        }
        public IActionResult Committees()
        {
            APIHandler webHandler = new APIHandler();
            Committees committees = webHandler.GetCommittees();
            return View(committees);

        }
        public IActionResult Filings()
        {
            APIHandler webHandler = new APIHandler();
            Filings Filings = webHandler.GetFilings();
            return View(Filings);

        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
