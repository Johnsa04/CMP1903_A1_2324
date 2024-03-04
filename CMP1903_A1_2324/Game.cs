using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        private Random random = new Random();
        private Die Dice_1;
        private Die Dice_2;
        private Die Dice_3;

        public Game()
        {
            Dice_1 = new Die(random);
            Dice_2 = new Die(random);
            Dice_3 = new Die(random);
        }

        public void Play()
        {
            int result = Dice_1.Roll() + Dice_2.Roll() + Dice_3.Roll();
            Console.WriteLine("Result of rolling three dice: " + result);
        }
    }
}
