using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses.Exceptions
{
    public class ProductNotFoundException:Exception
    {
        public ProductNotFoundException(string msg):base(msg)
        {

        }
    }
}
