using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDog.Exceptions
{
    class LengthLowerThan2 : ApplicationException
    {
        public LengthLowerThan2(string message = "The name ca not be lower than 2") : base(message)
        {

        }
    }
}
