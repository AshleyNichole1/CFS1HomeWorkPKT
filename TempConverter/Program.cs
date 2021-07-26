using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)

        {

            string questionloop;

            do
            {
                Console.WriteLine("I can convert temperatures for you.\n" + "Would you like to convert from Celsius or from Fahrenheit?");
                Console.WriteLine("Enter C to convert from celcius to fahrenheit, or and F from fahrenheit to celsius.");

                string userInput = Console.ReadLine().ToLower();



                if (userInput == "c" || userInput == "celsius ")
                {
                    Console.WriteLine("Please input a temperature in celsius,. I will convert to fahrenheit");
                    double celsius = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Fahrenheit = {(celsius * 9) / 5 + 32}");


                }

                else if (userInput == "f" || userInput == "fahrenheit")
                {


                    Console.WriteLine("Enter a temperature in Fahrenheit and I'll turn it to celsius.");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"Celsius = {(fahrenheit - 32) / 9 * 5}");

                }
                else
                {
                    Console.WriteLine("Invalid. Try again.");
                }
                Console.WriteLine("Would you like to try again? Enter yes or no.");
                questionloop = Console.ReadLine();

                Console.Clear();


            } while (questionloop == "y" || questionloop == "yes");
            

        }
    }
}
