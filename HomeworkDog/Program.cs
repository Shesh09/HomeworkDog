using System;
using HomeworkDog.Exceptions;

namespace HomeworkDog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            try
            {
                Dog doggie = new Dog("Steward", 10);
            }
            catch (ExceptionAgeGreaterThan100 ea)
            {

                Console.WriteLine(ea.Message);
            }
            catch (LengthLowerThan2 ll)
            {

                Console.WriteLine(ll.Message);
            }
            catch (NegativeAgeException na)
            {

                Console.WriteLine(na.Message);
            }
            finally { Console.WriteLine("Everything is all right"); }
        }
    }
}
