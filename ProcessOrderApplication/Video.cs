using System;
using System.Collections.Generic;

namespace ProcessOrderApplication
{
    internal class Video : NonPhysicalProduct
    {
        public Video(string productname)
        {
            ProductName = productname;
            Operations = new List<string>();
            GenerateSlip();
        }

        public override void GenerateSlip()
        {
            base.GenerateSlip();
            if (ProductName.ToLower().Equals("learning to ski"))
            {
                Operations.Add("'First Aid' video added to the packing slip");
                Console.WriteLine("'First Aid' video added to the packing slip");
            }
        }
    }
}