﻿using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Client
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a first name")]
        [StringLength(300, ErrorMessage = "Hey, you can't enter more than 300 letters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a last name")]
        [StringLength(300, ErrorMessage = "Hey, you can't enter more than 300 letters!")]
        public string LastName { get; set; }

        [Required]
        [StringLength(18, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        public Address Address { get; set; }

        [Required(ErrorMessage = "You must enter a phone number")]        
        [RegularExpression(@"^05[2, 3, 4, 8]{1}[-]{0,1}[\s\./0-9]{7}$")]
        public String PhoneNumber { get; set; }

        [Display(Name = "Email address")]
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }



        public DateTime DateOfBirth { get; set; }//איך מגבילים תאריך
        [RegularExpression(@"(^(((0[1-9]|1[0-9]|2[0-8])[\/](0[1-9]|1[012]))|((29|30|31)[\/](0[13578]|1[02]))|((29|30)[\/](0[4,6,9]|11)))[\/](19|[2-9][0-9])\d\d$)|(^29[\/]02[\/](19|[2-9][0-9])(00|04|08|12|16|20|24|28|32|36|40|44|48|52|56|60|64|68|72|76|80|84|88|92|96)$)")]
        public ICollection<Order> Orders { get; set; }


    }
}