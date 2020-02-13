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
            name = "Robo";
            score = 0;
        }

        //Member Methods
        public override void ChooseGestures() //random choice of gestures
        {
            Random ran = new Random();
            int randomIndex = ran.Next(0, 5); // "next" is a method
            gesture = gestures[randomIndex];
        }

    }
}
