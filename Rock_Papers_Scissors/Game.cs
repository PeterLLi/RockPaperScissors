using System;
using System.Collections.Generic;

namespace Rock_Papers_Scissors
{
    public class Game
    {
        public int numOfPlayers;
        Players playerOne;
        Players playerTwo;
        public string playerCount;
        public string userGesture;
        public int choice;

        public void GetNumberOfPlayers()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("Welcome to rock paper scissor lizard spock.");
                Console.WriteLine("Would you like to play with two players or against AI?");
                playerCount = Console.ReadLine();
                playerCount.ToLower();

                if (playerCount != "one" && playerCount != "two" && playerCount != "")
                {
                    Console.WriteLine("Please enter either one or two!");
                }
                if (playerCount == "")
                {
                    Console.WriteLine("Please enter something!");
                }
            }while(playerCount != "one" && playerCount != "two" && playerCount == "");

            if (playerCount == "one")
            {
                PlayerOneGesture();
                Computer computer = new Computer();
            }
            else if (playerCount == "two")
            {
                Humans humans = new Humans();
            }
        }

        public void PlayerOneGesture(){
            Console.WriteLine("What gesture do you want to pick? Rock, paper, scissors, lizard, spock.");
            userGesture = Console.ReadLine();
            userGesture.ToLower();

            switch (userGesture)
            {
                case "rock":
                    choice = 0;
                    break;
                case "paper":
                    choice = 1;
                    break;
                case "scissors":
                    choice = 2;
                    break;
                case "lizard":
                    choice = 3;
                    break;
                case "spock":
                    choice = 4;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option!");
                    PlayerOneGesture();
                    break;
            }
        }

        public string Gesture()
        {
            List<string> gestures = new List<string>();
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");

            return gestures[choice];
        } 
    }
}
