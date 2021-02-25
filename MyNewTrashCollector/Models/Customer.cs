using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyNewTrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Pick Up Day")]
        public string PickupDay { get; set; }
        //[Display(Name = "Pick Up Day")]
        //public bool IsConfirmed { get; set; }
        [Display(Name = "Amount Owed")]
        public float AmountOwed { get; set; }
        [Display(Name = "One Time Pickup Date")]
        public string OneTimePickupDate { get; set; }
        [Display(Name = "Start Date for Temporary Pickup")]
        public string TempSuspendStartDate { get; set; }
        [Display(Name = "End Date for Temporary Pickup")]

        public string TempSuspendEndDate { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }




    }
}
