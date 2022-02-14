using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AmazonMission.Models;
using AmazonMission.Models.ViewModels;

namespace AmazonMission.Controllers
{
    public class HomeController : Controller
    {

        //private IAmazonMissionRepository repo;

        //public HomeController (IAmazonMissionRepository temp)
        //{
        //    repo = temp;
        //}

        public IActionResult Index(int pageNum = 1)
        {
            //int pageSize = 5;

            //var x = new BooksViewModel
            //{
            //    Books = repo.Projects
            //    .OrderBy(p => p.ProjectName)
            //    .Skip((pageNum - 1) * pageSize)
            //    .Take(pageSize),

            //    PageInfo = new PageInfo
            //    {
            //        TotalNumProjects = repo.Projects.Count(),
            //        ProjectsPerPage = pageSize,
            //        CurrentPage = pageNum
            //    }
            //};

            return View();
        }
    }
}
