﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coivd_App.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "First name is requried")]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is requried")]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Password is requried")]
       // [Display(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Phone number name is requried")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone numeber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address name is requried")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        public string Email { get; set; }

        [Display(Name = "Mark if diagnosed")]
        [Required(AllowEmptyStrings = false)]
        public bool Diagnosed { get; set; }

        [Display(Name = "Date of birth")]
        public DateTime BirthDate { get; set; }





    }
}