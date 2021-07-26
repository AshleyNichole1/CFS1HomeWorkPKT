using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's do a mad lib :)");
            Console.WriteLine("\nEnter Yes or No to continue....");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "yes" || userInput == "y")
            {

                Console.WriteLine("Noun - Person, place or thing EX: inside, belief, Betty Crocker ");
                Console.WriteLine("verb - Describes an action, state or occurrence EX: Run, Think, Dance");
                Console.WriteLine("Adjective - Words that are used to describe or modify nouns or pronouns. EX: Red, quick, big\n");

                string[] nouns = new string[6];

                Console.WriteLine("List 6 nouns individually, pressing enter after eachone.");
                nouns[0] = Console.ReadLine();
                nouns[1] = Console.ReadLine();
                nouns[2] = Console.ReadLine();
                nouns[3] = Console.ReadLine();
                nouns[4] = Console.ReadLine();
                nouns[5] = Console.ReadLine();

                string[] verbs = new string[4];

                Console.WriteLine("List 4 verbs individually, pressing enter after eachone.");

                verbs[0] = Console.ReadLine();
                verbs[1] = Console.ReadLine();
                verbs[2] = Console.ReadLine();
                verbs[3] = Console.ReadLine();

                Console.WriteLine("Name a State. EX: Missouri, Florida etc.");
                string state = Console.ReadLine();

                Console.WriteLine("Give a proper name - Bob, Rhonda, Joe etc.");
                string name = Console.ReadLine();

                Console.WriteLine("Name a body part.");
                string bodyPart = Console.ReadLine();

                string[] adjectives = new string[2];

                Console.WriteLine("List 2 adjectives");
                adjectives[0] = Console.ReadLine();
                adjectives[1] = Console.ReadLine();

                string[] miscellaneous = new string[4];

                Console.WriteLine("List a relative (aunt, uncle, mom etc), an activity, a restauant and your favorite month. Be sure to hit enter with each answer!");
                miscellaneous[0] = Console.ReadLine();
                miscellaneous[1] = Console.ReadLine();
                miscellaneous[2] = Console.ReadLine();
                miscellaneous[3] = Console.ReadLine();

                string[] extras = new string[3];

                Console.WriteLine("Finally, I'll need a past tense adjective, past tense verb and a plural noun. Again be sure to hit enter after your input!");
                extras[0] = Console.ReadLine();
                extras[1] = Console.ReadLine();
                extras[2] = Console.ReadLine();

                Console.WriteLine($"A {nouns[0]} in {state} was arrested this morning after he {verbs[0]} in front of a {nouns[1]}.");

                Console.WriteLine($"{name}, had a history of {verbs[1]}, but no one - not even his {nouns[2]}-ever imagined he'd {verbs[2]} "
                    + $"with a {nouns[3]} stuck in his {bodyPart}.");

                Console.WriteLine($"*I always thought he was {adjectives[0]}, but I never thought he'd do something like this. Even his {miscellaneous[0]} was surprised.*");

                Console.WriteLine($"After a brief {miscellaneous[1]}, cops followed him to a {miscellaneous[2]}, where he reportedly {extras[0]} in the fry machine.");

                Console.WriteLine($"In {miscellaneous[3]}, a woman was charged with a {nouns[4]}, she {extras[1]} with a {adjectives[1]} dog.");

                Console.WriteLine($"Either way, we imagine that after witnessing him {verbs[3]} with a {nouns[5]} there are probably a whole lot of {extras[2]} that are going to need some therapy. ");
              
            }

            else if (userInput == "no" || userInput == "n")
            {
                Console.WriteLine("I didn't want to play with you anyway.");
            }

            else
            {
                Console.WriteLine("Invalid input, try again!");
            }


        }
    }
}
