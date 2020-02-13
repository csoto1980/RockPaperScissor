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
            score = 0;
            Console.WriteLine("Enter Player name: ");
            name = Console.ReadLine();
        
        }
        //Member Methods
        public override void ChooseGestures()
        {
            Console.WriteLine("Choose your gesture: (1-Rock, 2-Paper, 3-Scissors, 4-Lizard or 5-Spoke)");
            gesture = Console.ReadLine();
            if(gesture == "1" || gesture == "Rock" )
            {
                
                Console.WriteLine("Rock it is. Good Luck!");
                return;
            }
            else if (gesture == "2" || gesture == "Paper")
            {
                Console.WriteLine("Paper it is. Good Luck!");
                return;
            }
            else if (gesture == "3" || gesture == "Scissors")
            {
                Console.WriteLine("Scissors it is. Good Luck!");
                return;
            }
            else if (gesture == "4" || gesture == "Lizard")
            {
                Console.WriteLine("Lizard it is. Good Luck!");
                return;
            }
            else if (gesture == "5" || gesture == "Spoke")
            {
                Console.WriteLine("Spoke it is. Good Luck!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter number associated with your gesture choice");
                ChooseGestures();
            }
           
        }

    }
}
