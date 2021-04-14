using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Calendario.Models
{
    public class EventosModel
    {
          
        public int id { get; set; }
        public string title { get; set; }
        public DateTime start { get; set; }
        public DateTime end { get; set; }
        public string description { get; set; }
        public string color { get; set; }
    }


    public class EventosModelJSON
    {

        public int id { get; set; }
        public string title { get; set; }
        public string start { get; set; }
        public string end { get; set; }
        public string description { get; set; }
        public string color { get; set; }
    }
}