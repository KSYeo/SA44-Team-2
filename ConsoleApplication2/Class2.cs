using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class2
    {
        static void Main()
        {
            int a = 1;
            Console.WriteLine(a);

            a++;

            Console.WriteLine(a);               //a++ = a+1, =>2

            a--;

            Console.WriteLine(a);               //a-- = a-1 =>1

            ++a;

            Console.WriteLine(a);               // ++a = a+1 =>2}

            int b = a;                          //b is independant of a. It only takes the value of a AT THE POINT it is implemented
            Console.WriteLine(a++);             //a is incremented after WriteLine
            Console.WriteLine(b); b = b + 1;
            Console.WriteLine(++a);             //a is incremented before WriteLine
            b = b + 1; Console.WriteLine(b);

            Console.WriteLine("\nMessing around starts here");
            int c = 3;
            Console.WriteLine(c += 4);          // basically translates to c+4
            
        }
    }
}
