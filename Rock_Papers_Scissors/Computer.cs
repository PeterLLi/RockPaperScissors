using System;

namespace Rock_Papers_Scissors{
    public class Computer:GetPlayers{
        public Computer(){
            String firstPlayerGesture;
            int roll;

            Random rnd = new Random();
            roll = rnd.Next(0, 4);

            Console.WriteLine(roll);

            firstPlayerGesture = Console.ReadLine();

            Gesture();
        }
    }
}
