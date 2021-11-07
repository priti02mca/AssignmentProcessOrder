using System;
using System.Collections.Generic;

namespace ProcessOrderApplication
{
    internal class Book : PhysicalProduct
    {
        public Book(string productname)
        {
            ProductName = productname;
            Operations = new List<string>();
            GenerateSlip();
            base.GenerateCommission();
        }
        public override void GenerateSlip()
        {
            base.GenerateSlip();
            Operations.Add("Create a duplicate packing slip for the royalty department.");
            Console.WriteLine("Create a duplicate packing slip for the royalty department.");
        }
    }
}