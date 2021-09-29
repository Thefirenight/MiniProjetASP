using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail ln
        public ActionResult lnDetails(int? id)
        {
            if (id == 0)
                return HttpNotFound();
            if (!id.HasValue)
                 return HttpNotFound();
            else
            {
                //converti json en string puis en object rootobject
                string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Data.json");
                var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
                // search ln avec id 
                DataModel.LightNovel result = root.listLightNovels.Where(ln => ln.ID == id)
                                               .Select(ln => new DataModel.LightNovel
                                               {
                                                   ID = ln.ID,
                                                   Name = ln.Name,
                                                   Associated_Name = ln.Associated_Name,
                                                   Description = ln.Description,
                                                   Genre = ln.Genre,
                                                   Authors = ln.Authors,
                                                   Artits = ln.Artits,
                                                   Year = ln.Year,
                                                   Volume = ln.Volume,
                                                   Url = ln.Url,
                                                   Image = ln.Image
                                               }).FirstOrDefault();
                return View(result);
            }
        }

        // GET: Detail wn
        public ActionResult wnDetails(int? id)
        {
            if (id == 0)
                return HttpNotFound();
            if (!id.HasValue)
                return HttpNotFound();
            else
            {
                string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Data.json");
                var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
                DataModel.WebNovel result = root.listWebNovels.Where(wn => wn.ID == id)
                                               .Select(wn => new DataModel.WebNovel
                                               {
                                                   ID = wn.ID,
                                                   Name = wn.Name,
                                                   Associated_Name = wn.Associated_Name,
                                                   Description = wn.Description,
                                                   Genre = wn.Genre,
                                                   Authors = wn.Authors,
                                                   Artits = wn.Artits,
                                                   Year = wn.Year,
                                                   Chapter = wn.Chapter,
                                                   Url = wn.Url,
                                                   Image = wn.Image
                                               }).FirstOrDefault();
                return View(result);
            }
        }

        // GET: Detail manga
        public ActionResult mangaDetails(int? id)
        {
            if (id == 0)
                return HttpNotFound();
            if (!id.HasValue)
                return HttpNotFound();
            else
            {
                string json = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Data\Data.json");
                var root = JsonConvert.DeserializeObject<DataModel.Rootobject>(json);
                DataModel.Manga result = root.listMangas.Where(manga => manga.ID == id)
                                               .Select(manga => new DataModel.Manga
                                               {
                                                   ID = manga.ID,
                                                   Name = manga.Name,
                                                   Associated_Name = manga.Associated_Name,
                                                   Description = manga.Description,
                                                   Genre = manga.Genre,
                                                   Authors = manga.Authors,
                                                   Artits = manga.Artits,
                                                   Year = manga.Year,
                                                   Chapter = manga.Chapter,
                                                   Url = manga.Url,
                                                   Image = manga.Image
                                               }).FirstOrDefault();
                return View(result);
            }
        }
    }
}