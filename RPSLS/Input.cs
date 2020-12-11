using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    static class Input // ADDED STATIC !  - -  - - Convention for this class should be called USER INTERFACE
    {

        static string selectedGesture;
        static string gameModeSelected;
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
            while(Console.ReadKey(true).Key != ConsoleKey.D1 && Console.ReadKey(true).Key != ConsoleKey.D2)
            {
                Console.WriteLine("You entered an incorrect option.\n" +
                    "To play against the computer, Please press 1\n" +
                "To play against another human, Please press 2\n");
            }
            if(Console.ReadKey(true).Key == ConsoleKey.D1)
            {
                Console.WriteLine("You have selected to play against the computer. Good Luck !\n");
                Console.ReadLine();
                PlayerVsAIGestureSelection();
            }
            else
            {
                Console.WriteLine("You will be playing against another human. Be nice to each other ! \n");
                Console.ReadLine();
                PlayerVsPlayerGestureSelection();

            }
        }
        public static void PlayerVsPlayerGestureSelection()
        {
            int i = 1;
            Console.WriteLine("Choose your best Gesture !\n" +
                "These are your choices.\n");
            foreach (var item in Game.gestureNames)
            {

                Console.WriteLine("For " + item + ": Press " + i);
                i++;
            }
            Console.ReadLine();
        }
        public static void PlayerVsAIGestureSelection()
        {

        }
    }
}
