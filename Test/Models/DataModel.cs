using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class DataModel
    {

        public class Rootobject
        {
            [JsonProperty("LightNovel")]
            public List<LightNovel> listLightNovels { get; set; }

            [JsonProperty("WebNovel")]
            public List<WebNovel> listWebNovels { get; set; }

            [JsonProperty("Manga")]
            public List<Manga> listMangas { get; set; }
        }

        public class LightNovel
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Associated_Name { get; set; }
            public string Description { get; set; }
            public string Genre { get; set; }
            public string Authors { get; set; }
            public string Artits { get; set; }
            public string Year { get; set; }
            public int Volume { get; set; }
            public string Image { get; set; }
            public string Url { get; set; }
        }

        public class WebNovel
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Associated_Name { get; set; }
            public string Description { get; set; }
            public string Genre { get; set; }
            public string Authors { get; set; }
            public string Artits { get; set; }
            public string Year { get; set; }
            public int Chapter { get; set; }
            public string Url { get; set; }
            public string Image { get; set; }
        }

        public class Manga
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Associated_Name { get; set; }
            public string Description { get; set; }
            public string Genre { get; set; }
            public string Authors { get; set; }
            public string Artits { get; set; }
            public string Year { get; set; }
            public int Chapter { get; set; }
            public string Url { get; set; }
            public string Image { get; set; }
        }

    }
}