﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEKISI_DATA_LIBRARY.Models
{
    public class TaxiRouteModel
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Name { get; set; }
    }

    public class DeleteTaxiRouteBindingModel
    {
        [Required]
        public int Id { get; set; }
    }
}
