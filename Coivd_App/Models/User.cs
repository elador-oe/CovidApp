using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coivd_App.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public bool Diagnosed { get; set; }

        public DateTime BirthDate { get; set; }





    }
}