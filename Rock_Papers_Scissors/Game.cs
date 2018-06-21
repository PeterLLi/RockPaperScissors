using System;
using System.Collections.Generic;

namespace Rock_Papers_Scissors
{
    public class Game
    {
        public int numOfPlayers;

        public Game()
        {
            Player player = new Player();
            player.GetNumberOfPlayers();
        }
    }
}
