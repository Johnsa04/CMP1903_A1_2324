using System;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        private Game game;

        public Testing()
        {
            game = new Game();
        }

        public void PlayGame()
        {
            game.Play();

            // Get the current values of the dice
            int dice1Value = game.Dice_1.CurrentValue;
            int dice2Value = game.Dice_2.CurrentValue;
            int dice3Value = game.Dice_3.CurrentValue;

            // Ensure the dice rolls are between 1 and 6 inclusive
            Debug.Assert(dice1Value >= 1 && dice1Value <= 6, "Dice 1 roll is not between 1 and 6");
            Debug.Assert(dice2Value >= 1 && dice2Value <= 6, "Dice 2 roll is not between 1 and 6");
            Debug.Assert(dice3Value >= 1 && dice3Value <= 6, "Dice 3 roll is not between 1 and 6");

            // Calculate the sum of the rolls
            int sum = dice1Value + dice2Value + dice3Value;

            // Ensure the sum is correct (between 3 and 18 inclusive)
            Debug.Assert(sum >= 3 && sum <= 18, "Sum of dice rolls is not between 3 and 18");
        }
    }
}