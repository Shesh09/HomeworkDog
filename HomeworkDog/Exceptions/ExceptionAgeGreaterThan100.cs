using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDog.Exceptions
{
    class ExceptionAgeGreaterThan100 : ApplicationException
    {
        public ExceptionAgeGreaterThan100(string massage= "Age can not be greater than 100 ") : base(massage)
        {

        }
    }
}
