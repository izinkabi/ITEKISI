using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEKISI_API.Models
{
    public class Taxi
    {

        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }

    }
}