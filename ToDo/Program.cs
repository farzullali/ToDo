using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ToDoCirclePerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool checkResponse = true;
            do
            {
                double radius;
            checkpoint:
                //Take user circle radius
                Console.WriteLine("Inpute circle radius: ");
                string value = Console.ReadLine();

                //check value 
                bool checkValue = double.TryParse((value), out radius);

                if (checkValue)
                {
                    // if true then parse
                    radius = double.Parse(value);
                }
                else
                {
                    //if false message user and go back
                    Console.WriteLine("Wrong input");
                    goto checkpoint;
                }
                //call method perimeter of Circle
                double perimeter = CirclePerimetr(radius);
                Console.WriteLine($"Your circle perimeter is: {perimeter}");

                checkpoint2:
                Console.WriteLine("One more time?! (Y - yes /N - no)");
                string response = Console.ReadLine().ToUpper();

                // check exit answer
                if (response == "Y")
                {
                    continue;
                }
                else if(response == "N")
                {
                    checkResponse = false;
                }
                else
                {
                    Console.WriteLine("wrong input. Please say Y/N");
                    goto checkpoint2;
                }
            } while (checkResponse);

        }

        public static double CirclePerimetr(double radius)
        {
            return radius * 3.14 * 2;
        }


    }
}
