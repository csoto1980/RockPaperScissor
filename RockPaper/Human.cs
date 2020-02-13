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
            Console.WriteLine("Choose your gesture: (1-Rock, 2-Paper, 3-Scissors, 4-Lizard or 5-Spoke)");
            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                Console.WriteLine("Rock it is. Good Luck!");
            }
            else if (input == 2)
            {
                Console.WriteLine("Paper it is. Good Luck!");
            }
            else if (input == 3)
            {
                Console.WriteLine("Scissors it is. Good Luck!");
            }
            else if (input == 4)
            {
                Console.WriteLine("Lizard it is. Good Luck!");
            }
            else if (input == 5)
            {
                Console.WriteLine("Spoke it is. Good Luck!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter number associated with your gesture choice");
                return;
            }
        }

    }
}
