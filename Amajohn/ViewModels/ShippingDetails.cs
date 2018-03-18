using System;
using System.ComponentModel.DataAnnotations;

namespace Amajohn.ViewModels
{
    public class ShippingDetails
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        public bool GiftWrap { get; set; }
    }
}
    