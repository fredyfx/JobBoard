using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobBoard.Models.JsonJobModel
{
    public class JsonJob
    {
        public int ID { get; set; }
        public string ApplicationLink { get; set; }
        public string Company { get; set; }
        public string DatePosted { get; set; }
        public string Experience { get; set; }
        public string Hours { get; set; }
        public string JobID { get; set; }
        public string JobTitle { get; set; }
        public string LanguagesUsed { get; set; }
        public string Location { get; set; }
        public string Salary { get; set; }
    }
}
