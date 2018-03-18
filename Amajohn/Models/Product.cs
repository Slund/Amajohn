using System;
namespace Amajohn.Models
{
    public class Product
    {
        public int ProductId { set; get; }
		public string Title { set; get; }
        public int Quantity { set; get; } //
        private decimal price;
		public string ImageUrl { set; get; }
        public string Category { set; get; }

		public decimal Price
		{
			set
			{
				if (value <= 0)
				{
					throw new Exception("Price is not accepted");
				}
				else
				{
					price = value;
				}
			}
			get { return price; }
		}

        public Product()
		{
		}

        public Product(string title, decimal price)
		{
            Title = title;
            Price = price;
		}
    }
}
