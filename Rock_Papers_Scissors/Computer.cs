using System;

namespace Rock_Papers_Scissors{
    public class Computer:Player{
        public Computer(){
            Random rnd = new Random();
            int roll = rnd.Next(1, 5);
        }
    }
}
