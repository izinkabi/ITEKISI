using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEKISI_DATA_LIBRARY.Models
{
    public class TaxiModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Location { get; set; }
        public string Price { get; set; }
    }
}
