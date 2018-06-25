using System;

namespace Rock_Papers_Scissors{
    public class Humans : Players{
        public Humans(string humanName){
            this.humanName = humanName;
            Console.WriteLine(this.humanName);

        }
    }
}
