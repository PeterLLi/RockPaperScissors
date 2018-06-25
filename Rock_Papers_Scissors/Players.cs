using System;
using System.Collections.Generic;

namespace Rock_Papers_Scissors{
    public class Players{
        public string userGesture;
        public string computerName;
        public string humanName;
        public string gesturesString;
        public int choice;
        public List<string> gestures = new List<string>();

        public virtual void PlayerGesture(){
            Gesture();
            Console.WriteLine("What gesture do you want to pick? Your choices are: ");
            gesturesString = string.Join(", ", gestures.ToArray());
            Console.WriteLine(gesturesString);

            userGesture = Console.ReadLine();
            userGesture.ToLower();

            switch(userGesture){
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
                    Console.WriteLine(gestures);
                    PlayerGesture();
                    break;
            }
        }

        public virtual void Gesture(){
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }
    }
}