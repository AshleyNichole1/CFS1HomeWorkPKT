using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Fruit = new string[6];
            Fruit[0] = "Apple";
            Fruit[1] = "Orange";
            Fruit[2] = "Pear";
            Fruit[3] = "Kiwi";
            Fruit[4] = "Banana";
            Fruit[5] = "Grape";

            for (int FruitNames = 0; FruitNames < 6; FruitNames++)
            {
                Console.Write(Fruit[FruitNames] + ".");



                for (int J = 0; J < FruitNames; J++)
                {

                    Console.Write(".");

                }
                Console.WriteLine();

            }//END FOR









        }//END MAIN
    }//END CLASS
}//END NAMESPACE
