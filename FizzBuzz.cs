using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {    
        }
        public string FizzBuzzMethod(int number)
        {
            

                if ((number % 3 == 0) && (number % 5 == 0))
                {
                    Console.WriteLine("FizBuzz");
                    
                }
                else
                if (number % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    
                }
                else
                if (number % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    
                }
                else
                {
                    Console.WriteLine(number);
                    
                }
                return number.ToString();
            
            
            
        }
    }
}
