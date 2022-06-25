using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollerLogic
{
    public class DiceRoller
    {
        private List<Dice> DiceCollection = new List<Dice>();
        public string Collection 
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                int i = 1;
                foreach (Dice dice in DiceCollection)
                {
                    sb.AppendLine($"{i}. {dice.ToString}");
                    i++;
                }
                return sb.ToString();
            }
        }
    }
}
