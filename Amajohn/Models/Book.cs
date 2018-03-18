using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Amajohn.Models
{
    [Table("Books")]
    public class Book : Product
    {
		public string Author { set; get; }
		public string Publisher { set; get; }
		public short Published { set; get; }
		public string ISBN { set; get; }

		public Book()
		{
		}

        public Book(string author, string title, decimal price, short published) : base(title, price)
		{
            Author = author;
            Published = published;
		}
    }
}
