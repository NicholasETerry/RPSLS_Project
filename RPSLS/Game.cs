using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
     class Game
    {

        //As a developer i want to store all gesture options in a list as a way to utilize the list of gestures in my code
        public Rock newRock = new Rock();
        public Paper newPaper = new Paper();
        public Sissors newScissors = new Sissors();
        public Lizard newLizard = new Lizard();
        public Spock newSpock = new Spock();
        static public List<string> gestureNames = new List<string>();

        Gestures CompeatingGestureOne;
        Gestures CompeatingGestureTwo;

        bool didGestureWin = false;
        bool didGesturesTie = false;

        Human newHuman = new Human();
        ArtificialIntelligence newAI = new ArtificialIntelligence();
        // MEMBER VARIABLE ( HAVE A )


        // CONSTRUCTOR ( SPAWNER )
        public Game()
        {
            MakeRock();
            MakePaper();
            MakeScissors();
            MakeLizard();
            MakeSpock();
            Input.Welcome();
            Input.GameModeCreater();
            CompairGestures(newSpock, newPaper);
            CheckForWinner();
            CompairGestures(newPaper, newSpock);
            CheckForWinner();
            CompairGestures(newRock, newPaper);
            CheckForWinner();
            CompairGestures(newPaper, newRock);
            CheckForWinner();

            //foreach (var item in newRock.WinningGesture)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("Rock wins against these");
            //    Console.ReadLine();
            //}
            //foreach (var item in newRock.LoosingGesture)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("Rock looses against these");
            //    Console.ReadLine();
            //}
        }
        // MEMBER METHOD ( CAN DO )
        public void CompairGestures(Gestures firstGesture,Gestures secondGesture) // THIS IS CALLED BY ANOTHER METHOD THAT GOT USERINPUT
        {
            CompeatingGestureOne = firstGesture;
            CompeatingGestureTwo = secondGesture;
            // GOES THROUGH WINNINGGESTURE LIST FOR FIRST ITEM TO SEE IF IT WINS AGAINST SECONDGESTURE
            foreach (var item in firstGesture.WinningGesture)
            {
                if( item == secondGesture)
                {
                    didGestureWin = true;

                }
                else if ( item != secondGesture)
                {
                    foreach (var nextItem in firstGesture.LoosingGesture)
                    {
                        if(nextItem == secondGesture)
                        {
                            didGestureWin = false;
                        }
                    }
                }
                else
                {
                    didGesturesTie = true;
                }
            }
        }
        public void CheckForWinner()
        {
            if(didGestureWin == true && didGesturesTie == false)
            {
                Console.WriteLine(CompeatingGestureOne.gestureName + " has won against " + CompeatingGestureTwo.gestureName);
            }
            else if (didGestureWin == false && didGesturesTie == false)
            {
                Console.WriteLine(CompeatingGestureTwo.gestureName + " has won against " + CompeatingGestureOne.gestureName);
            }
            else if (didGestureWin == false && didGesturesTie == true)
            {
                Console.WriteLine(CompeatingGestureOne.gestureName + " has tied against " + CompeatingGestureTwo.gestureName);
            }
            Console.ReadLine();
        }
        public void MakeRock()
        {
            newRock.CreateGesture(newRock, newScissors, true);
            newRock.CreateGesture(newRock, newPaper, false);
            newRock.CreateGesture(newRock, newLizard, true);
            newRock.CreateGesture(newRock, newSpock, false);
            newRock.DisplayItemsInList(newRock.WinningGesture);
            newRock.DisplayItemsInList(newRock.LoosingGesture);
            gestureNames.Add(newRock.gestureName);
        }
        public void MakePaper()
        {
            newPaper.CreateGesture(newPaper, newScissors, false);
            newPaper.CreateGesture(newPaper, newRock, true); 
            newPaper.CreateGesture(newPaper, newLizard, false); 
            newPaper.CreateGesture(newPaper, newSpock, true);
            newRock.DisplayItemsInList(newPaper.WinningGesture);
            newRock.DisplayItemsInList(newPaper.LoosingGesture);
            gestureNames.Add(newPaper.gestureName);
        }
        public void MakeScissors()
        {
            newScissors.CreateGesture(newScissors, newPaper, true);
            newScissors.CreateGesture(newScissors, newSpock, false);
            newScissors.CreateGesture(newScissors, newLizard, true);
            newScissors.CreateGesture(newScissors, newRock, false);
            newRock.DisplayItemsInList(newScissors.WinningGesture);
            newRock.DisplayItemsInList(newScissors.LoosingGesture);
            gestureNames.Add(newScissors.gestureName);
        }
        public void MakeLizard()
        {
            newLizard.CreateGesture(newLizard, newRock, false);
            newLizard.CreateGesture(newLizard, newSpock, true);
            newLizard.CreateGesture(newLizard, newScissors, false);
            newLizard.CreateGesture(newLizard, newPaper, true);
            newRock.DisplayItemsInList(newLizard.WinningGesture);
            newRock.DisplayItemsInList(newLizard.LoosingGesture);
            gestureNames.Add(newLizard.gestureName);
        }
        public void MakeSpock()
        {
            newSpock.CreateGesture(newSpock, newLizard, false);
            newSpock.CreateGesture(newSpock, newScissors, true);
            newSpock.CreateGesture(newSpock, newPaper, false);
            newSpock.CreateGesture(newSpock, newRock, true);
            newRock.DisplayItemsInList(newSpock.WinningGesture);
            newRock.DisplayItemsInList(newSpock.LoosingGesture);
            gestureNames.Add(newSpock.gestureName);
        }
    }
}
