using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessOrderApplication
{
    public class ProcessOrder
    {
        public static Product GetProductTypeAndName(string[] input)
        {
            enums.ProductType type;
            try
            {
                type = (enums.ProductType)Enum.Parse(typeof(enums.ProductType), input[0], ignoreCase: true);
            }
            catch (Exception e)
            {
                type = enums.ProductType.Other;
            }
            Product product;
            string productname = input.Length > 1 ? input[1] : string.Empty;
            switch (type)
            {
                case enums.ProductType.Membership:
                    {
                        product = new Membership();
                        break;
                    }
                case enums.ProductType.Book:
                    {
                        product = new Book(productname);
                        break;
                    }
                case enums.ProductType.Other:
                default:
                    {
                        product = new Other(productname);
                        break;
                    }
            }
            return product;
        }
    }
}
