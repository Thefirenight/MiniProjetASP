using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class ListController : Controller
    {
        // GET: Book
        public ActionResult LightNovels()
        {
            string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory+ @"\Data\Data.json");
            var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
            return View(root);
        }
        public ActionResult WebNovels()
        {
            string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Data.json");
            var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
            return View(root);
        }
        public ActionResult Mangas()
        {
            string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Data.json");
            var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
            return View(root);
        }
    }
}