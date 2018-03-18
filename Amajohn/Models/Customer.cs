using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amajohn.Models
{
    public class Customer
    {
        public int CustomerId { set; get; }
        public string Firstname { set; get; }
        public string Lastname { set; get; }
		public string Address { set; get; }
		public string Zip { set; get; }
		public string City { set; get; }
        public string Email { set; get; }

        // Using DataAnnotation to convert column. Also included using.System.Comp..
        [Column(TypeName = "datetime2")]
        public DateTime Birthdate { get; set; }

        public int Age {
			get {
				DateTime now = DateTime.Now;
				int age = 0;
                age = now.Year - Birthdate.Year;
				if (now.Month < Birthdate.Month || 
                    (now.Month == Birthdate.Month && now.Day < Birthdate.Day))
				{
					age--;
				}
				return age; } 
		}

        public virtual ICollection<Phone> PhoneNumbers { get; set; }

        public Customer() {}

        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city)
        {
            CustomerId = customerId;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            Zip = zip;
            City = city; 
        }

        public void AddPhone(Phone phone) {
            PhoneNumbers.Add(phone);
        }

	}
}
