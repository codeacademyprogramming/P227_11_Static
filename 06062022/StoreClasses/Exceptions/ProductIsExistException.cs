using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses.Exceptions
{
    public class ProductIsExistException:Exception
    {
        public ProductIsExistException(string msg):base(msg)
        {

        }
    }
}
