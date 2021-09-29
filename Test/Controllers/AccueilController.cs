using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace Test.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Data.json");
            var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
            return View(root);
        }
    }
}