using System;
using System.Collections.Generic;

namespace ProcessOrderApplication
{
    internal class Membership : NonPhysicalProduct
    {
        public Membership()
        {
            Operations = new List<string>();
            Operations.Add("Activate that membership.");
            Console.WriteLine("Activate that membership.");
            base.SendEmailToOwner();
        }
    }
}