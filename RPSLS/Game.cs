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
        public Sissors newScissor = new Sissors();
        public Lizard newLizard = new Lizard();
        public Spock newSpock = new Spock();
        static public List<string> gestureNames = new List<string>();
        // MEMBER VARIABLE ( HAVE A )


        // CONSTRUCTOR ( SPAWNER )
        public Game()
        {
            RockPopulateGestureListWL();
            PaperPopulateGestureListWL();
            ScissorsPopulateGestureListWL();
            LizardPopulateGestureListWL();
            SpockPopulateGestureListWL();
            Input.Welcome();
            Input.GameModeCreater();
        }
        // MEMBER METHOD ( CAN DO )
        public void RockPopulateGestureListWL()
        {
            newRock.CreateGesture(newRock, newScissor, true);
            newRock.CreateGesture(newRock, newPaper, false);
            newRock.CreateGesture(newRock, newLizard, true);
            newRock.CreateGesture(newRock, newSpock, false);
            newRock.DisplayItemsInList(newRock.WinningGesture);
            newRock.DisplayItemsInList(newRock.LoosingGesture);
            gestureNames.Add(newRock.gestureName);
        }
        public void PaperPopulateGestureListWL()
        {
            newPaper.CreateGesture(newPaper, newScissor, false);
            newPaper.CreateGesture(newPaper, newRock, true);
            newPaper.CreateGesture(newPaper, newLizard, false);
            newPaper.CreateGesture(newPaper, newSpock, true);
            newRock.DisplayItemsInList(newPaper.WinningGesture);
            newRock.DisplayItemsInList(newPaper.LoosingGesture);
            gestureNames.Add(newPaper.gestureName);
        }
        public void ScissorsPopulateGestureListWL()
        {
            newScissor.CreateGesture(newScissor, newPaper, true);
            newScissor.CreateGesture(newScissor, newSpock, false);
            newScissor.CreateGesture(newScissor, newLizard, true);
            newScissor.CreateGesture(newScissor, newRock, false);
            newRock.DisplayItemsInList(newScissor.WinningGesture);
            newRock.DisplayItemsInList(newScissor.LoosingGesture);
            gestureNames.Add(newScissor.gestureName);
        }
        public void LizardPopulateGestureListWL()
        {
            newLizard.CreateGesture(newLizard, newRock, false);
            newLizard.CreateGesture(newLizard, newSpock, true);
            newLizard.CreateGesture(newLizard, newScissor, false);
            newLizard.CreateGesture(newLizard, newPaper, true);
            newRock.DisplayItemsInList(newLizard.WinningGesture);
            newRock.DisplayItemsInList(newLizard.LoosingGesture);
            gestureNames.Add(newLizard.gestureName);
        }
        public void SpockPopulateGestureListWL()
        {
            newSpock.CreateGesture(newSpock, newLizard, false);
            newSpock.CreateGesture(newSpock, newScissor, true);
            newSpock.CreateGesture(newSpock, newPaper, false);
            newSpock.CreateGesture(newSpock, newRock, true);
            newRock.DisplayItemsInList(newSpock.WinningGesture);
            newRock.DisplayItemsInList(newSpock.LoosingGesture);
            gestureNames.Add(newSpock.gestureName);
        }
    }
}
