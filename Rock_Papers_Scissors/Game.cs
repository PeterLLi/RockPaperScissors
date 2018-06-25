using System;

namespace Rock_Papers_Scissors{
    public class Game{
        public int numOfPlayers;
        public int playerOneChoice;
        public int playerTwoChoice;
        public int playerOnePoints;
        public int playerTwoPoints;
        public string playerCount;
        Players players = new Players();
        Players playerOne;
        Players playerTwo;


        public void RunGame(){
            GetNumberOfPlayers();
            while() {
                InitiatePlayerGame();

            }
        }

        public void GetNumberOfPlayers(){
            do{
                Console.WriteLine("Welcome to rock paper scissor lizard spock.");
                Console.WriteLine("Would you like to play with one or two players?");
                playerCount = Console.ReadLine();
                playerCount.ToLower();

                if(playerCount != "one" && playerCount != "two" && playerCount != ""){
                    Console.WriteLine("Please enter either one or two!");
                }

                if(playerCount == ""){
                    Console.WriteLine("Please enter something!");
                }
            }while(playerCount != "one" && playerCount != "two" && playerCount == "");

            if (playerCount == "one"){
                playerOne = new Humans("Player 1");
                playerTwo = new Computer("Computer");
                InitiatePlayerGame();
                Console.WriteLine(playerOne.choice);
                Console.WriteLine(playerTwo.choice);
            }

            if (playerCount == "two"){
                playerOne = new Humans("player1");
                playerTwo = new Humans("player2");
                InitiatePlayerGame();

                Console.WriteLine(playerOne.choice);
                Console.WriteLine(playerTwo.choice);


            }
        }

        public void InitiatePlayerGame(){
            playerOne.PlayerGesture();
            playerTwo.PlayerGesture();
        }
    }
}