﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace ITEKISI_API.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public int AccessId { get; set; }
    }
}