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
        public int RollDice()
        {
            return IRoller.GetOutcome(Range);
        }
        public override string ToString()
        {
            return $"{Name} can roll values from 1 to {Range}";
        }
    }
}