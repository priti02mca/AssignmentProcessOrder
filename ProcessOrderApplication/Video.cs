using System.Collections.Generic;

namespace ProcessOrderApplication
{
    internal class Video : NonPhysicalProduct
    {
        public Video(string productname)
        {
            ProductName = productname;
            Operations = new List<string>();
            base.GenerateSlip();
        }
    }
}