using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeFLV.Models
{
    public class Capitulos
    {
        public int ID { get; set; }
        public string Name { get; set;}
        public string Url { get; set; }
        public int SerieId { get; set; }
    }
}