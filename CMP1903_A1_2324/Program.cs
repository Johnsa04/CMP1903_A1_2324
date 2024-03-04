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
            game.Play(); // This will roll the dice, calculate the sum, and print the result.

            // Testing object creation
            Testing new_test = new Testing();

            Console.ReadKey();

            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
        }
    }
}
