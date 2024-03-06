using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int FinalScore = game.Play(); // This will roll the dice, calculate the sum, and print the result.
            Console.WriteLine("the sum of the dice roll is " + FinalScore);

            // Testing object creation
            Testing test1 = new Testing();
            test1.PlayGame();

            Console.ReadKey();

            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            //this is the code, i did it wrong lol
        }
    }
}
