﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {   
        
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Pickup Day")]
        public string PickupDay { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public int Zipcode { get; set; }

        [Display(Name = "Suspended")]
        
        public bool isSuspended { get; set; }

        [Display(Name = "Start Suspension Date")]

        public string StartSuspension { get; set; }

        [Display(Name = "End Suspension Date")]
        public string EndSuspension { get; set; }

        [Display(Name = "Free Pickup")]
        public string OneTimePickup { get; set; }

        [Display(Name = "Balance")]
        public double Balance { get; set; }

        [Display(Name = "Picked Up")]
        public bool PickUp { get; set; }
        

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
     
    }
}
