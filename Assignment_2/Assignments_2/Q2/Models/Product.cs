using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2.Models
{
    internal class Product
    {
        private double price;
        private int stockQuantity;
        public string Name { get; set; }
        public double Price
        {
            get { return price; } 
            set
            { 
                if(value < 0) 
                    price = 0;
                else { price = value; }
            }
        }
        public int StockQuantity
        { 
            get { return stockQuantity; }
            set 
            {
                if(value < 0)
                    stockQuantity = 0;
                else { stockQuantity = value; }
            }
        }
        public bool IsAvailable
        {
            get
            {
                return (StockQuantity > 0);
            }
        }

        public bool AdjustStockAndAvailability(Product product)
        {
            if(product.IsAvailable) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"product {Name} have {StockQuantity} quantity in stock and price {Price}"; 
        }

    }
}
