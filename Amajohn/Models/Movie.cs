using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Amajohn.Models
{
    [Table("Movie")]
    public class Movie : Product
    {
		// fields
        private string director;
        private short released;

        // properties
		public string Director {
            get { return director; } // read
            set { director = value; } // write
		}

		public short Released {
			get { return released; } // read
			set { released = value; } // write
		}

		// constructors
        public Movie() {}

		public Movie(string title, decimal price) : base(title, price) {
            Price = price;
        }

        public Movie(string title, decimal price, string imageUrl, string director) : base(title, price)
        {
			Director = director;
            ImageUrl = imageUrl;
        }
    }
}