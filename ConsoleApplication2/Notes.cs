using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ISS");        

            Console.WriteLine("\nShe says, \"Hello\"");                         // use \ when intending to display certain characters such as " (\")

            Console.Write("\n*\n**\n***\n\n");                                  // \n denotes a new line

            Console.WriteLine("Name\t\tAge");                                   // \t denotes a Tab
            Console.WriteLine("John Smith\t21");
            Console.WriteLine("Jane Spencer\t22");
            Console.WriteLine("Jimbo Shade\t23\n\n");

            int a = 5;
            double b = 10;
            double c = 15;
            Console.WriteLine( a +"+" + b+ "+" + c +"=" + (a + b + c));
            Console.WriteLine("{0}+{1}+{2}={3}", a, b, c, a + b + c);           // simplifies the above. {0} corresponds to a, {1} corresponds to b, etc.

            Console.WriteLine(String.Format("\n{0:0.00}\n", (a+b+c)));          // forces the console to display a whole number to have decimal places


            double d = 70.8;
            double e = 100.2;
            Console.WriteLine(String.Format("{0:0.0}",(e + d)));
            Console.WriteLine(String.Format("{0:0.0}",(a + d)));        // note that a is an integer function but after this line, int + double becomes a double

            Console.WriteLine("\n\nHe weighs {0:0.00}kg and is {1:0.00}cm tall\n", d, e); // Note that {0:0.00} refers to {0} to be presented in a 0.00 format

            double balance = 12345.123;
            double balance2 = 12344445.321;
            Console.WriteLine("${0}", balance);
            Console.WriteLine("${0:0,000.00}", balance+balance2);            // , in this case denotes the format of 0,000 which is the thousands separator (in this csae used with currency)
            Console.WriteLine("${0:0,0.00}\n\n", balance + balance2);

            double x = 123;
            double y = 33.334;
            Console.WriteLine("{0}    {1}", x, y);
            Console.WriteLine("{0:#.###}    {1:#.###}",x,y);                    //# denotes a field where it will input if it is needed. If not, it will be ignored
            Console.WriteLine("{0:00000}", x);                                  //the {0:00000} can be used to force the console to display empty fields. In this case, the 2 zeroes
            Console.WriteLine("{0:#####}\n\n", x);                                  // as can be seen, # ignores the first 2 zeroes
            
            
            /*
             
                */
        }
    }
}
