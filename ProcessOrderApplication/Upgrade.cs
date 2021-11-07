using System;
using System.Collections.Generic;

namespace ProcessOrderApplication
{
    internal class Upgrade : NonPhysicalProduct
    {
        public Upgrade()
        {
            Operations = new List<string>();
            Operations.Add("apply the upgrade.");
            Console.WriteLine("apply the upgrade.");
            base.SendEmailToOwner();
        }
    }
}