﻿namespace ITEKISI_API.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";

        public int ProfileId { get; set; }
    }
}