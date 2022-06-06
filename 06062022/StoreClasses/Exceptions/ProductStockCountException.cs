using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses.Exceptions
{
    public class ProductStockCountException:Exception
    {
        public ProductStockCountException(string msg):base(msg)
        {

        }
    }
}
