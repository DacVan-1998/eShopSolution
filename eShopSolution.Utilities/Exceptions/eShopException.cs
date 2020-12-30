using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Utilities.Exceptions
{
    public class eShopException : Exception
    {
        public eShopException() 
        { 
        }

        public eShopException(string message) : base(message)
        {
        }

        public eShopException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
