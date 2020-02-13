using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class Computer : Player
    {
        //member variables
        

        //Constructor
        public Computer()
        {
            score = 0;
            name = "Robo";
            Console.WriteLine("Computer players name is Robo");
        }

        //Member Methods
        public override void ChooseGestures()
        {
            List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spoke" };
            Random ran = new Random();
            int randomIndex = ran.Next(0, 5);
            gesture = gestures[randomIndex];
            Console.WriteLine("Robo's gesture is " + gesture + ".");
           
        }

    }
}
