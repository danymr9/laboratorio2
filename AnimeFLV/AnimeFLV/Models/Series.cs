using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeFLV.Models
{
    public class Series
    {
        public int ID { get; set; }
        public string CategoriaId { get; set; }
        public string Name { get; set; }
        public string synopsis { get; set; }
        public string ImagePath { get; set; }
        
    }
}