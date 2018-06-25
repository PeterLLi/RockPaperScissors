using System;

namespace Rock_Papers_Scissors{
    public class Computer : Players{
        public int roll;
        public Computer(string computerName){
            this.computerName = computerName;
        }

        public override void PlayerGesture(){
            Random rnd = new Random();
            roll = rnd.Next(0, 4);
            choice = roll;
        }
    }
}
