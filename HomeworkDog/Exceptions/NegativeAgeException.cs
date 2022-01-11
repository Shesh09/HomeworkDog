using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDog.Exceptions
{
    class NegativeAgeException : ApplicationException
    {
        public NegativeAgeException(string message= "Age can not be under 0") : base(message)
        {
            
        }
    }
}
