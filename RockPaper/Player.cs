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

        }
        //Method
        public abstract void ChooseGestures();

    }

}
