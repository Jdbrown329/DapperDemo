using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public class Product
    {
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int OnSale { get; set; }  
        public string StockLevel { get; set; }

    }
}
