using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaper
{
    public class Game
    {
        //Member Variables
        public Player player1;
        public Player player2;
        List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spoke" };

        //Constructor
        public Game()
        {
           
            player1.ChooseGestures();
            player2.ChooseGestures();
        }

        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard Spock. The rules are simple");
            Console.WriteLine("/n");
            Console.WriteLine("Ro");
        }
        public void ComparingGestures(int player1Gesture, int player2Gesture)
        {
            if(player1Gesture > player2Gesture)
            {
                //increase player1 score by 1 point
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if(player1Gesture < player2Gesture)
            {
                //increase player2 score by 1 point
                Console.WriteLine("Player 2 wins this round!");
            }
            else
            {
                Console.WriteLine("Tie...play again.");
            }
        }

        //Methods
        public string GetNumberOfPlayers()
        {
            Console.WriteLine("1 or 2 players?");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }
        private void SetPlayers(string numberOFPlayers)
        {
            if (numberOFPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberOFPlayers == "2")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else
            {
                player1 = new Computer();
                player2 = new Computer();
            }
        }
        public void DisplayGameWinner(int player1Score, int player2Score)
        {
            if (player1Score == 3)
            {
                Console.WriteLine("Player 1 wins the game!");
            }
            else if (player2Score == 3)
            {
                Console.WriteLine("Player 2 wins the game!");
            }
        }
        public void RunGame()
        {
            string players = GetNumberOfPlayers();
            SetPlayers(players);
            player1.ChooseGestures();
            player2.ChooseGestures();
            //ComparingGestures();
        }
        //public void DisplayGestureOptioins()
        // {
        //list of gestures
        //}
        //public string GetStringInput(string word)
        // {
        //Console.WriteLine($"Enter{word}");
        //  string input = Console.ReadLine();
        //return input;
        // }

    }

}
