using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public abstract class Player
    {
        //Member Variables
        public string name;
        public int score;
        public string gesture;
        public List<string> gestures;

        //Constructor
        public Player()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spoke");
        }
     
        //Method
        public abstract void ChooseGestures();
   




    }
}
