using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {

            const string accountNumber = "123456";
            const string pinNumber = "1234";
            decimal accountBalance = 0;
            int tries = 1;
            int userAttempts = 3;
            string userInput = "";
            const string userPin = "1234";
            bool repeat = true;


            while (userInput != accountNumber && tries <= userAttempts)
            {
                Console.WriteLine("Please enter your AccountNumber");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == accountNumber)
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
                    Console.WriteLine("AccountNumber incorrect. Please try again");


                }

                tries++;

            }



            tries = 1;

            while (userInput != userPin && tries <= userAttempts)
            {
                Console.WriteLine("Please enter your PIN number");
                userInput = Console.ReadLine().ToUpper();

                if (userInput == userPin)
                {

                    Console.WriteLine("Thank you!");
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


            Console.Clear();
            do
            {

                Console.WriteLine("\n\nPlease choose a function.\n" +
                    "1) Deposit\n2) Withdrawal\n3) Balance\n4) Exit");
                string userOption = Console.ReadLine().ToUpper();


                switch (userOption)
                {
                    case "D":
                    case "DEPOSIT":
                    case "1":
                        Console.WriteLine("How much would you like to deposit");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("{0:c} has been deposited into account ending in 3456", deposit);
                        accountBalance = accountBalance + deposit;
                        Console.WriteLine("Your new account balance is {0:c}", accountBalance);
                        Console.WriteLine("Press any key to return to main menu");
                        Console.ReadKey();
                        break;

                    case "2":
                    case "WITHDRAWAL":
                    case "W":
                        Console.WriteLine("How much would you like to withdrawal?");
                        decimal userWithdraw = Convert.ToDecimal(Console.ReadLine());

                        if (userWithdraw >= accountBalance)
                        {
                            Console.WriteLine("Invalid account balance");
                        }
                        else
                        {
                            Console.WriteLine("{0:c} has been withdrawn for account ending in 3456", userWithdraw);
                        }
                        accountBalance = accountBalance - userWithdraw;
                        Console.WriteLine("Your new account balance is {0:c}", accountBalance);

                        break;

                    case "3":
                    case "B":
                    case "BALANCE":
                        Console.WriteLine("Your account balance is {0:c}", accountBalance);
                        Console.WriteLine("Press any key to return to main menu");
                        Console.ReadKey();
                        break;


                    case "4":
                    case "E":
                    case "EXIT":
                        Console.WriteLine("Thank you for using our service.");
                        repeat = false;
                        Console.WriteLine("Press any key to return to main menu");
                        Console.ReadKey();
                        break;


                    default:
                        Console.WriteLine("Input unrecognized. Please restart and try again.");                      
                        Console.ReadKey();
                        break;
                } //END SWITCH

                Console.Clear();
            } while (repeat) ;
           



        }
    }
}
