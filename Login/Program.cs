using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class Program
    {
        static void Main(string[] args)

        {
            const string userName = "ASHLEYSMITH";
            int userAttempts = 3;
            const string userPin= "1234";
            string userInput="";
            int tries = 1;          
            

            //if user input matches user name access granted
            //if user input does not match access denied
            //if userinput did not match allow 2 more attempts
            //if after 3 attempts the username still does not match. close program.





            while (userInput != userName && tries <= userAttempts)
            {
                Console.WriteLine("Please enter your username");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == userName)
                {
                    Console.WriteLine("Thank you access has been granted");
                }
                else if (tries == userAttempts)
                {
                    Console.WriteLine("Incorrect. Access Denied");

                    
                    return;
                }

                else
                {
                    Console.WriteLine("UserName incorrect. Please try again");


                }
               
                tries++;

            }



            tries = 1;

            while (userInput != userPin && tries  <= userAttempts)
            {
                Console.WriteLine("Please enter your PIN number");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == userPin)
                {
                    Console.WriteLine("Thank you access has been granted");
                }
                else if (tries == userAttempts)
                {
                    Console.WriteLine("Incorrect. Access Denied");


                    return;
                }

                else
                {
                    Console.WriteLine("Pin number incorrect. Please try again");


                }

                tries++;

            }



        }
    }
}
