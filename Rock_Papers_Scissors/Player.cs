using System;

namespace Rock_Papers_Scissors
{
    public class Player
    {
        public String playerOne;
        public String playerTwo;
        public String computerPlayer;
        public String userPlayerCount;

        public void GetNumberOfPlayers()
        {
            do
            {
                Console.WriteLine("Welcome to rock paper scissor lizard spock.");
                Console.WriteLine("Would you like to play with two players or against AI?");
                userPlayerCount = Console.ReadLine();
                userPlayerCount.ToLower();

                if (userPlayerCount != "one" || userPlayerCount != "two"){
                    Console.WriteLine("Please enter either one or two!");
                    Console.WriteLine("\n");
                }

                while (userPlayerCount == "")
                {
                    Console.WriteLine("Please enter something!");
                    Console.WriteLine("How many players? (One or two)");
                    userPlayerCount = Console.ReadLine();
                    userPlayerCount.ToLower();
                }
            }while(userPlayerCount != "one" || userPlayerCount != "two");

            if(userPlayerCount == "one"){
                Computer computer = new Computer();
            } else if(userPlayerCount == "two") {
                Humans humans = new Humans();
            }
        }
    }
}