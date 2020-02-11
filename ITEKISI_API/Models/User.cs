using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITEKISI_API.Models
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }
}