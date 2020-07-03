using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.entity
{
    public class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public decimal? UnitPrice { get; set; }
         public bool Discontinued { get; set; }

    }
}
