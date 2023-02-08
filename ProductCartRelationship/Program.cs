using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCartRelationship
{

    class Cart
    {
        private List<CartItem> items = new List<CartItem>();

        public void AddProduct(Product product, int quantity)
        {
            // Check if the product already exists in the cart
            CartItem existingItem = items.Find(item => item.Product.Id == product.Id);

            if (existingItem != null)
            {
                // If the product already exists in the cart, update the quantity
                existingItem.Quantity += quantity;
            }
            else
            {
                // If the product does not exist in the cart, add it as a new item
                CartItem newItem = new CartItem { Product = product, Quantity = quantity };
                items.Add(newItem);
            }
        }

        public List<CartItem> GetItems()
        {
            return items;
        }
    }

    class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

