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

    public abstract class PhysicalProduct : Product
    {
        public override void GenerateSlip()
        {
            Operations.Add("Generated a packing slip for shipping.");
            Console.WriteLine("Generated a packing slip for shipping.");
        }
        public virtual void GenerateCommission()
        {
            Operations.Add("Added commission payment to the agent.");
            Console.WriteLine("Added commission payment to the agent.");
        }
    }
}