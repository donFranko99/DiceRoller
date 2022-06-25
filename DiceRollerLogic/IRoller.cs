using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLogic
{
    public interface IRoller
    {
        private static readonly Random randomizer = new Random();
        /// <summary>
        /// Method that returns outcome of a single dice roll.
        /// </summary>
        /// <param name="range"> Maximum value of a dice roll. </param>
        /// <returns> Integer value containing outcome of the roll. </returns>
        protected static int GetOutcome(int range)
        {
            return randomizer.Next(1, range+1);
        }

        public int RollDice();
    }
}
