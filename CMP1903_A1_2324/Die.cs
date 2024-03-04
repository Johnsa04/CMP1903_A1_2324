using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        private Random random;

        public int CurrentValue;

        public Die(Random random)
        {
            this.random = random;
            Roll();
        }

        public int Roll()
        {
            CurrentValue = random.Next(1, 7);
            return CurrentValue;
        }
    }
}