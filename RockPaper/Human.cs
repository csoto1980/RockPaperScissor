using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class Human : Player
    {
        //Member Variables

        //Constructor
        public Human()
        {
            Console.WriteLine("Enter Player name: ");
            name = Console.ReadLine();
            score = 0;
        }
        //Member Methods
        public override void ChooseGestures()
        {
            Console.WriteLine("Choose your gesture: (1-Rock, 2-Papers, 3-Scissors, 4-Lizard or 5-Spoke");
            int input = int.Parse(Console.ReadLine());
        }

    }
}
