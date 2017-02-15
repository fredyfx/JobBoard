using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Models.WebsiteModel
{
    public class WebsiteID
    {
        public int ID { get; set; }
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public float Salary { get; set; }
        public string Hours { get; set; }
        public string Experience { get; set; }
        public DateTime DatePosted { get; set; }
        public string Languages { get; set; }
        public string URL { get; set; }
    }
}
