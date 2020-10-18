using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimeFLV.Models
{
    public class Series
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }

    }
}