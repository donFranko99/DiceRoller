using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLogic
{
    public class Dice : IRoller
    {
        /// <summary>
        /// Property returns maximum possible outcome of a dice roll.
        /// </summary>
        public int Range { get; protected set; }

        /// <summary>
        /// Property returns a name of a dice.
        /// (dice name is connected to its range ex. d20, d6, d4, ...)
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Property returns description of visual pattern of the dice.
        /// </summary>
        public string Pattern { get; protected set; }

        /// <summary>
        /// Constructor for general dices.
        /// </summary>
        /// <param name="range"> Maximum outcome of a dice </param>
        /// <param name="name"> Name of a dice </param>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        public Dice(int range, string name="d" , string pattern="default")
        {
            Range = range;
            Name = name;
            Pattern = pattern;
        }

        /// <summary>
        /// Method which returns outcome of a simulated dice roll.
        /// </summary>
        /// <returns> Integer value which varies from 1 to dice range. </returns>
        public int RollDice()
        {
            return IRoller.GetOutcome(Range);
        }

        public override string ToString()
        {
            return $" This {Name} can roll values from 1 to {Range}.\nIt has a {Pattern} pattern.";
        }

        /// <summary>
        /// Returns a d4 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice. </param>
        /// <returns> Dice object with range equal to 4. </returns>
        public static Dice GetD4(string pattern = "default") => new Dice(4, "d4", pattern);

        /// <summary>
        /// Returns a d6 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice. </param>
        /// <returns> Dice object with range equal to 6. </returns>
        public static Dice GetD6(string pattern = "default") => new Dice(6, "d6", pattern);

        /// <summary>
        /// Returns a d8 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        /// <returns> Dice object with range equal to 8. </returns>
        public static Dice GetD8(string pattern = "default") => new Dice(8, "d8", pattern);

        /// <summary>
        /// Returns a d10 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        /// <returns> Dice object with range equal to 10. </returns>
        public static Dice GetD10(string pattern = "default") => new Dice(10, "d10", pattern);

        /// <summary>
        /// Returns a d12 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        /// <returns> Dice object with range equal to 12. </returns>
        public static Dice GetD12(string pattern = "default") => new Dice(12, "d12", pattern);

        /// <summary>
        /// Returns a d20 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        /// <returns> Dice object with range equal to 20. </returns>
        public static Dice GetD20(string pattern = "default") => new Dice(20, "d20", pattern);

        /// <summary>
        /// Returns a d100 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        /// <returns> Dice object with range equal to 100. </returns>
        public static Dice GetD100(string pattern = "default") => new Dice(100, "d100", pattern);

        /// <summary>
        /// Returns a d100 dice with a certain pattern.
        /// </summary>
        /// <param name="pattern"> Description of visual pattern of the dice </param>
        /// <returns> Dice object with range equal to 100. </returns>
        public static List<Dice> GetDiceSet(string pattern = "default")
        {
            List<Dice> set = new List<Dice>();
            set.Add(GetD4(pattern));
            set.Add(GetD6(pattern));
            set.Add(GetD8(pattern));
            set.Add(GetD10(pattern));
            set.Add(GetD12(pattern));
            set.Add(GetD20(pattern));
            set.Add(GetD100(pattern));
            return set;
        }
    }
}