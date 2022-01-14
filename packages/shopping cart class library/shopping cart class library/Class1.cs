using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopping_cart_class_library
{
    public class Class1
    { 
        public string food_name;
        public double unitprice;
        public double quantity;
        public double price;
        public double total;

        public double CalPrice()
        {
            price = unitprice * quantity;
            return price;
            

        }

        public double get_total()
        {
            total = total + price;
            return total;

        }

         
       
    }
}