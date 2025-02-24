using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace POS_System
{
    internal class OrderDetails
    {
        public int Quantity { get; private set; }
        public int ProductID { get; private set; }

        public OrderDetails(int quantity, int productID)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.", nameof(quantity));

            if (productID <= 0)
                throw new ArgumentException("Product ID must be greater than zero.", nameof(productID));

            Quantity = quantity;
            ProductID = productID;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.", nameof(newQuantity));

            Quantity = newQuantity;
        }

        public void UpdateProductID(int newProductID)
        {
            if (newProductID <= 0)
                throw new ArgumentException("Product ID must be greater than zero.", nameof(newProductID));

            ProductID = newProductID;
        }
    }
}

