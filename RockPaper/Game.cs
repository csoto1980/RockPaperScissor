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

        //Constructor
        public Game()
        {

        }

        //Methods
        public void StartGame()
        {
            Console.WriteLine(); 
            Console.WriteLine("Welcome to - ROCK-PAPER-SCISSORS-LIZARD-SPOCK - The Game");
            Console.WriteLine("********************************************************");
            Console.WriteLine("             ROCK-PAPER-SCISSORS-LIZARD-SPOCK");
            Console.WriteLine("         was created by internet pioneer, Sam Kass ");
            Console.WriteLine("       as an improvement on the classic game of ");
            Console.WriteLine("                   ROCK-PAPER-SCISSORS");
            Console.WriteLine("********************************************************");
            Console.WriteLine();
            Console.WriteLine("         HOW DOES IT WORK? ...Oh, it's very simple:");
            Console.WriteLine("                   Scissors cut Paper");          
            Console.WriteLine("                   Paper covers Rock");           
            Console.WriteLine("                   Rock crushes Lizard");          
            Console.WriteLine("                   Lizard poisons Spoke");            
            Console.WriteLine("                   Spock smashes Scissors");
            Console.WriteLine("                   Scissors decapitates Lizard");            
            Console.WriteLine("                   Lizard eats Paper");           
            Console.WriteLine("                   Paper disproves Spock");           
            Console.WriteLine("                   Spock vaporizes rock");            
            Console.WriteLine("      ...and as it always has...Rock crushes Scissors");
            Console.WriteLine();
            Console.WriteLine("********************************************************");
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("1 or 2 players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void SetPlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (numberOfPlayers == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else
            {
                player1 = new Computer();
                player2 = new Computer();
            }
        }
        public void ComparingGestures(string player1Gesture, string player2Gesture)
        {
            if ((player1Gesture == "Rock" || player1Gesture == "1") && (player2Gesture == "Scissors" || player2Gesture == "3"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 win s this round!!");
            }
            else if ((player1Gesture == "Rock" || player1Gesture == "1") && (player2Gesture == "Lizard" || player2Gesture == "4"))
            {
                player1.score += 1;
                Console.WriteLine("Player 2 wins this round!");
            }
            else if ((player1Gesture == "Paper" || player1Gesture == "2") && (player2Gesture == "Rock" || player2Gesture == "1"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if ((player1Gesture == "Paper" || player1Gesture == "2") && (player2Gesture == "Spock" || player2Gesture == "5"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if ((player1Gesture == "Scissors" || player1Gesture == "3") && (player2Gesture == "Paper"|| player2Gesture == "2"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if ((player1Gesture == "Scissors" || player1Gesture == "3") && (player2Gesture == "Lizard" || player2Gesture == "4"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }

            else if ((player1Gesture == "Lizard" || player1Gesture == "4") && (player2Gesture == "Spock" || player2Gesture == "5"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if ((player1Gesture == "Lizard" || player1Gesture == "4") && (player2Gesture == "Paper" || player2Gesture == "2"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if ((player1Gesture == "Spock" || player1Gesture == "5") && (player2Gesture == "Scissors" || player2Gesture == "3"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }
            else if ((player1Gesture == "Spock" || player1Gesture == "5") && (player2Gesture == "Rock" || player2Gesture == "1"))
            {
                player1.score += 1;
                Console.WriteLine("Player 1 wins this round!!");
            }

            else if ((player2Gesture == "Rock" || player2Gesture == "1") && (player1Gesture == "Scissors" || player1Gesture == "3"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Rock" || player2Gesture == "1") && (player1Gesture == "Lizard" || player1Gesture == "4"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Paper" || player2Gesture == "2") && (player1Gesture == "Rock" || player1Gesture == "1"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Paper" || player2Gesture == "2") && (player1Gesture == "Spock" || player1Gesture == "5"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Scissors" || player2Gesture == "3") && (player1Gesture == "Paper" || player1Gesture == "2"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Scissors" || player2Gesture == "3") && (player1Gesture == "Lizard" || player1Gesture == "4"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Lizard" || player2Gesture == "4") && (player1Gesture == "Spock" || player1Gesture == "5"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Lizard" || player2Gesture == "4") && (player1Gesture == "Paper" || player1Gesture == "2"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Spock" || player2Gesture == "5") && (player1Gesture == "Scissors" || player1Gesture == "3"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player2Gesture == "Spock" || player2Gesture == "5") && (player1Gesture == "Rock" || player1Gesture == "1"))
            {
                player2.score += 1;
                Console.WriteLine("Player 2 wins this round!!");
            }
            else if ((player1Gesture == "Rock" || player1Gesture == "1") && (player2Gesture == "Rock" || player2Gesture == "1"))
            {
                Console.WriteLine("Tie...play again.");
            }
            else if ((player1Gesture == "Paper" || player1Gesture == "2") && (player1Gesture == "Paper" || player2Gesture == "2"))
            {
                Console.WriteLine("Tie...play again.");
            }
            else if ((player1Gesture == "Scissors" || player1Gesture == "3") && (player1Gesture == "Scissors" || player2Gesture == "3"))
            {
                Console.WriteLine("Tie...play again.");
            }
            else if ((player1Gesture == "Lizard" || player1Gesture == "4") && (player1Gesture == "Lizard" || player2Gesture == "4"))
            {
                Console.WriteLine("Tie...play again.");
            }
            else if ((player1Gesture == "Spock" || player1Gesture == "5") && (player1Gesture == "Spock" || player2Gesture == "5"))
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
            StartGame();
            int input = GetNumberOfPlayers();
            SetPlayers(input);
            player1.ChooseGestures();
            player2.ChooseGestures();
            ComparingGestures(player1.gesture, player2.gesture);
            while (player1.score < 3 && player2.score < 3)
            {
                player1.ChooseGestures();
                player2.ChooseGestures();
                ComparingGestures(player1.gesture, player2.gesture);
            }
            DisplayGameWinner();
        }
    }

}
