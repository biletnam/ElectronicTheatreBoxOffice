using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ElectronicTheatreBoxOffice.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int Administration { get; set; }
    }
}