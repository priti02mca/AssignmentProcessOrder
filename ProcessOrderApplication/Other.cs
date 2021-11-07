using System.Collections.Generic;

namespace ProcessOrderApplication
{
    internal class Other : PhysicalProduct
    {
        public Other(string productname)
        {
            ProductName = productname;
            Operations = new List<string>();
            base.GenerateSlip();
            base.GenerateCommission();
        }
    }
}