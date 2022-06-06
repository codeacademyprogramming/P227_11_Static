using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses.Exceptions
{
    public class ProductLimitIsFilledException:Exception
    {
        public ProductLimitIsFilledException(string msg):base(msg)
        {

        }
    }
}
