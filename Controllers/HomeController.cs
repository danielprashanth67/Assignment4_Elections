using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Assignment4_Elections.Models;
using Assignment4_Elections.APIHandlerManager;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Assignment4_Elections.Data;
using System.Data;

namespace Assignment4_Elections.Controllers
{
    public class HomeController : Controller
    {
        public ElectionContext dbContext;
        public HomeController(ElectionContext context)
        {
            dbContext = context;

        }
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
              foreach(var item in candidates.results)
            {
                if (dbContext.Candidates.Where(c => c.candidate_id.Equals(item.candidate_id)).Count() == 0)
                {
                    dbContext.Candidates.Add(item);
                }

            }
            dbContext.SaveChanges();


            return View(candidates);
            
        }
        public IActionResult Committees()
        {
            APIHandler webHandler = new APIHandler();
            Committees committees = webHandler.GetCommittees();
            foreach (var item in committees.results)
            {
                if (dbContext.Committees.Where(c => c.committee_id.Equals(item.committee_id)).Count() == 0)
                {

                    dbContext.Committees.Add(item);

                }


            }
            dbContext.SaveChanges();
            foreach (var item in committees.results)
            {
                Committee can = dbContext.Committees.First(a => a.committee_id == item.committee_id);
                string candi = string.Join(",", item.candidate_ids);
                can.candidate_id = candi;
            }


            dbContext.SaveChanges();
           
            return View(committees);

        }
        public IActionResult Filings()
        {
            APIHandler webHandler = new APIHandler();
            Filings Filings = webHandler.GetFilings();
            
            foreach (var item in Filings.results)
            {
                if (dbContext.Filings.Where(c => c.ending_image_number.Equals(item.ending_image_number)).Count() == 0)
                {
                    dbContext.Filings.Add(item);
                }
            }
           dbContext.SaveChanges();
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
