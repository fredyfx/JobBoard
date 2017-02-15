using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using JobBoard.Models.JsonJobModel;
using System.IO;

namespace JobBoard.Controllers
{
    public class JsonJobContentController : Controller
    {
        // to get physical paths to both web root and content root, core has to use
        // IHostingEnvironment as a dependency injection
        private readonly IHostingEnvironment _hostingEnvironment;

        // create the hosting env
        public JsonJobContentController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            // content root path will return just the local file path
            string contentRootPath = _hostingEnvironment.ContentRootPath;
            // desired route
            string jsonPath = contentRootPath + "\\AppData\\JobBoard.json";

            // if the directory exists, write it into a json string
            string json;
            try
            {
                json = System.IO.File.ReadAllText(jsonPath);
            }
            catch (DirectoryNotFoundException)
            {

                throw;
            }

            return Content(json);
            //return View();
        }
    }
}
