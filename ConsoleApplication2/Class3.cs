using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class3
    {
        static void Main()
        {
            Console.WriteLine(Math.Ceiling(14.1));      //Value will be 15 because rounding up (ceiling)
            Console.WriteLine(Math.Floor(16.9));        //Value will be 6 due to rounding down (floor)
            Console.WriteLine(Math.Round(3.5));         //Value will be 4 due to rounding
            Console.WriteLine(Math.Round(3.8532, 2));   //Value will round to 2 Decimal places (due to ,2)

            
            Console.WriteLine(Math.Ceiling(3.8676, 2));  //How to round this up to 3.87?

            
        }
    }
}
