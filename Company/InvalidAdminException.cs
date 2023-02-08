using System;
using System.Runtime.Serialization;

namespace Company
{
   
    internal class InvalidAdminException : Exception
    {


        public InvalidAdminException(String message)
            : base(message)
        {

        }

    }
}