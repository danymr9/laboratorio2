﻿using System;
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
        public List<Category> Categorias
        {
            get
            {
                var serializer = new JavaScriptSerializer();
                var file = HttpContext.Current.Server.MapPath("~/App_Data/categories.txt");
                var content = File.ReadAllText(file);
                return serializer.Deserialize<List<Category>>(content);
            }
        }
    }
}