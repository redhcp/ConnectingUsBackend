﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConnectingUsWebApp.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public Country Nationality { get; set; }
        public Country CountryOfResidence { get; set; }
        public Account Account { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreateDate { get; set; }

    }
}