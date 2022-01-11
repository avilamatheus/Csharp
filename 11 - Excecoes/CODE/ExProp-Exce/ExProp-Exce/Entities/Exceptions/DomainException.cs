using System;
using System.Collections.Generic;
using System.Text;

namespace ExProp_Exce.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
        }
    }
}
