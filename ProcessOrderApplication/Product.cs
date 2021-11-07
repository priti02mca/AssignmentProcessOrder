using System;
using System.Collections.Generic;

namespace ProcessOrderApplication
{
    public abstract class Product
    {
        public string ProductName { get; set; }
        public List<string> Operations { get; set; }
        public abstract void GenerateSlip();
    }
}