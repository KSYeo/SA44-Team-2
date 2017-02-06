using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Class1
    {
        public static void Main()
        {
            Console.WriteLine("Entrance Ticket: $25");
            Console.Write("Please Enter No of Tickets You Want: ");
            string input = Console.ReadLine();

            int numTix = Convert.ToInt32(input);                     //This converts a string to an integer. Also, consider using Convert.ToDouble
                                                                     //bool isOK = Int32.TryParse(input, out numTix);
                
            //Display Total Cost
            Console.WriteLine("Total Cost = ${0:0,0.00}\n\n", numTix * 25);

          
        }
    }
}
