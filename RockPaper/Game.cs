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
        
        public int player1Score;
        public int player2Score;
        public string player1Gesture;
        public string player2Gesture;
        public Player player1;
        public Player player2;
        List<Player> gestures;
        //List<string> gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spoke" };

        //Constructor
        public Game()
        {
            gestures = new List<Player>();
        }

        //Methods
        public void StartGame()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard Spock. The rules are simple");
            Console.WriteLine("/n");
            Console.WriteLine("Ro");
            string input = GetNumberOfPlayers();
            SetPlayers(input);
            PlayerRound();
            player1.ChooseGestures();
            player2.ChooseGestures();
        }
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
        public void PlayerRound()
        {
            player1.ChooseGestures();
            player2.ChooseGestures();
        }
        public void ComparingGestures(string player1Gesture, string player2Gesture)
        {
            if (player1Gesture == "Rock" && player2Gesture == "Scissors")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player1Gesture == "Rock" && player2Gesture == "Lizard")
            {
                player1.score += 1;
                Console.WriteLine("Player 2 wins this round!");
            }
            else if (player1Gesture == "Paper" && player2Gesture == "Rock")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player1Gesture == "Paper" && player2Gesture == "Spock")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player1Gesture == "Lizard" && player2Gesture == "Spock")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player1Gesture == "Lizard" && player2Gesture == "Paper")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player1Gesture == "Spock" && player2Gesture == "Scissors")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player1Gesture == "Spock" && player2Gesture == "Rock")
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if (player2Gesture == "Rock" && player1Gesture == "Scissors")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Rock" && player1Gesture == "Lizard")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Paper" && player1Gesture == "Rock")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Paper" && player1Gesture == "Spock")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Scissors" && player1Gesture == "Paper")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Scissors" && player1Gesture == "Lizard")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Lizard" && player1Gesture == "Spock")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Lizard" && player1Gesture == "Paper")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Spock" && player1Gesture == "Paper")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Spock" && player1Gesture == "Rock")
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if (player2Gesture == "Rock" && player1Gesture == "Rock")
            {
                Console.WriteLine("Tie...play again.");
            }
            else if (player2Gesture == "Paper" && player1Gesture == "Paper")
            {
                Console.WriteLine("Tie...play again.");
            }
            else if (player2Gesture == "Scissors" && player1Gesture == "Scissors")
            {
                Console.WriteLine("Tie...play again.");
            }
            else if (player2Gesture == "Lizard" && player1Gesture == "Lizard")
            {
                Console.WriteLine("Tie...play again.");
            }
            else if (player2Gesture == "Spoke" && player1Gesture == "Spoke")
            {
                Console.WriteLine("Tie...play again.");
            }
        }
        public void DisplayGameWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("Player 1 wins the game!");
            }
            else if (player2.score == 3)
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
            while (player1Score < 3 && player2Score <3)
            {
                player1.ChooseGestures();
                player2.ChooseGestures();
                ComparingGestures(player1Gesture, player2Gesture);
            }
            DisplayGameWinner();
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
