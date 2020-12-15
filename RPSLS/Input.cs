using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class Input // ADDED STATIC !  - -  - - Convention for this class should be called USER INTERFACE
    {
        public static bool checkValue = false;
        static Human newHuman;
        static ArtificialIntelligence newAI;
        public static string gestureIndex;
        public static bool wasStringGood;
        public static int wasNumberGood;
        // As a developer, i want to account for and handle bad user input, ensuring that any user input is validated and reobtained if necessary

        // MEMBER VARIABLE ( HAVE A )

        // CONSTRUCTOR ( SPAWNER )
        //public Input()
        //{
                // STATIC CLASSES DO NOT USE CONSTUCTORS
        //}



        // MEMBER METHOD ( CAN DO )
        public static void Welcome()
        {
            Console.WriteLine("Welcome to the Game ! \n" +
                "Please select your game mode !\n");
        }
        public static void GameModeCreater()
        {
            Console.WriteLine("To play against the computer, Please press 1\n" +
                "To play against another human, Please press 2\n");
            while(checkValue == false)
            {
                int readKey = Convert.ToInt32(Console.ReadKey(true).Key);
                if ( readKey == 49)
                {
                    Console.WriteLine("You have selected to play against the computer. Good Luck !\n");
                    checkValue = true;
                    HumanVsAIGestureSelection();
                }
                else if ( readKey == 50)
                {
                    Console.WriteLine("You will be playing against another human. Be nice to each other ! \n");
                    checkValue = true;
                    HumanVsHumanGestureSelection();
                }
                else
                {
                Console.WriteLine("You entered an incorrect option.\n" +
                    "To play against the computer, Please press 1\n" +
                "To play against another human, Please press 2\n");
                }
            }
        }
        public static void HumanVsHumanGestureSelection() // takes user input - 1 to find correct index number for gesture.
        {
            while (wasStringGood == false)
            {
                int i = 1;
                Console.WriteLine(" Player One: Choose your best Gesture !\n" +
                    "These are your choices.\n");
                foreach (var item in Game.gestureNames)
                {

                    Console.WriteLine("For " + item.gestureName + ": Press " + i);
                    i++;
                }
                gestureIndex = (Console.ReadKey(true).KeyChar).ToString();
                wasStringGood = int.TryParse(gestureIndex, out wasNumberGood);
                if (wasStringGood == false)
                {
                    Console.WriteLine("\nInvalid entry. Please try again.");
                }
            }
            wasStringGood = false;
            newHuman = new Human();
        }
        public static void HumanVsAIGestureSelection()
        {
            while (wasStringGood == false)
            {

            int i = 1;
            Console.WriteLine("Choose your best Gesture !\n" +
                "These are your choices.\n");
            foreach (var item in Game.gestureNames)
            {

                Console.WriteLine("For " + item.gestureName + ": Press " + i);
                i++;
            }
            gestureIndex = (Console.ReadKey(true).KeyChar).ToString();
            wasStringGood = int.TryParse(gestureIndex, out wasNumberGood);
                if(wasStringGood == false)
                {
                    Console.WriteLine("\nInvalid entry. Please try again.");
                }
            }
            wasStringGood = false;
            newAI = new ArtificialIntelligence();
        }
        public static void EndOfGame()
        {
            if (Game.playerOneGameScore == 2)
            {
                Console.WriteLine("Congrats ! Player One Wins.");
            }
            else if (Game.playerTwoGameScore == 2)
            {
                Console.WriteLine(" Congrats ! Player Two Wins.");
            }
            else
            {
                Console.ReadLine();
            }
            
        }
    }
}
