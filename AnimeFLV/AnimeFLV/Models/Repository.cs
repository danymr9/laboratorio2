using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add
using System.IO;
using System.Web.Script.Serialization;

namespace AnimeFLV.Models
{
    public class Repository
    {
        public List<Categorias> Categorias
        {
            get
            {
                var serializer = new JavaScriptSerializer();
                var file = HttpContext.Current.Server.MapPath("~/App_Data/categories.txt");
                var content = File.ReadAllText(file);
                return serializer.Deserialize<List<Categorias>>(content);
            }
        }

        public List<Series> Series
        {
            get
            {
                var serializer = new JavaScriptSerializer();
                var file = HttpContext.Current.Server.MapPath("~/App_Data/series.txt");
                var content = File.ReadAllText(file);
                return serializer.Deserialize<List<Series>>(content);
            }
        }

        public List<Capitulos> Capitulos
        {
            get
            {
                var serializer = new JavaScriptSerializer();
                var file = HttpContext.Current.Server.MapPath("~/App_Data/capitulos.txt");
                var content = File.ReadAllText(file);
                return serializer.Deserialize<List<Capitulos>>(content);
            }
        }

        public List<Estados> Estado
        {
            get
            {
                var serializer = new JavaScriptSerializer();
                var file = HttpContext.Current.Server.MapPath("~/App_Data/Estados.txt");
                var content = File.ReadAllText(file);
                return serializer.Deserialize<List<Estados>>(content);
            }
        }
    }
}