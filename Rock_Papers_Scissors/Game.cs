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

            while(playerOnePoints < 3 && playerTwoPoints < 3){
                InitiatePlayerGame();
                CompareValues();
            }

            if(playerOnePoints == 3){
                Console.WriteLine("Player 1 wins the game!");
            }else if(playerTwoPoints == 3){
                Console.WriteLine("Player 2 wins the game!");
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

            }

            if (playerCount == "two"){
                playerOne = new Humans("player1");
                playerTwo = new Humans("player2");
            }
        }

        public void InitiatePlayerGame(){
            playerOne.PlayerGesture();
            playerTwo.PlayerGesture();
        }

        public void CompareValues(){
            int d = (5 + playerOne.choice - playerTwo.choice) % 5;

            if((d == 1) || (d == 3)){
                Console.WriteLine("Player one wins!");
                playerOnePoints += 1;
            }else if((d == 2) || (d == 4)){
                Console.WriteLine("Player two wins!");
                playerTwoPoints += 1;
            }else if(d == 0){
                Console.WriteLine("It's a tie!");
            }
        }
    }
}