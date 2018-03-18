using System;
using System.Collections.Generic;
namespace Amajohn.Models
{
    public class OrderItem
    {
        public int OrderItemId { set; get; }
        public int ProductId { set; get; }
        public virtual Product Product { set; get; }
        public int Quantity { set; get; }
        public decimal TotalPrice { get { return Product.Price * Quantity; } }

        public OrderItem(Product product, int quantity) {
            Product = product;
            Quantity = quantity;
        }

        public OrderItem() {}

        public OrderItem(int orderItemID, Product product, int quantity)
        {
            OrderItemId = orderItemID;
            Product = product;
            Quantity = quantity;
        }
    }
}