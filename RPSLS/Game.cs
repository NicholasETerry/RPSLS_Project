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
        public static List<Gestures> gestureNames = new List<Gestures>();
        public static int playerOneGameScore;
        public static int playerTwoGameScore;
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
            gestureNames.Add(newRock);
        }
        public void PaperPopulateGestureListWL()
        {
            newPaper.CreateGesture(newPaper, newScissor, false);
            newPaper.CreateGesture(newPaper, newRock, true);
            newPaper.CreateGesture(newPaper, newLizard, false);
            newPaper.CreateGesture(newPaper, newSpock, true);
            gestureNames.Add(newPaper);
        }
        public void ScissorsPopulateGestureListWL()
        {
            newScissor.CreateGesture(newScissor, newPaper, true);
            newScissor.CreateGesture(newScissor, newSpock, false);
            newScissor.CreateGesture(newScissor, newLizard, true);
            newScissor.CreateGesture(newScissor, newRock, false);
            gestureNames.Add(newScissor);
        }
        public void LizardPopulateGestureListWL()
        {
            newLizard.CreateGesture(newLizard, newRock, false);
            newLizard.CreateGesture(newLizard, newSpock, true);
            newLizard.CreateGesture(newLizard, newScissor, false);
            newLizard.CreateGesture(newLizard, newPaper, true);
            gestureNames.Add(newLizard);
        }
        public void SpockPopulateGestureListWL()
        {
            newSpock.CreateGesture(newSpock, newLizard, false);
            newSpock.CreateGesture(newSpock, newScissor, true);
            newSpock.CreateGesture(newSpock, newPaper, false);
            newSpock.CreateGesture(newSpock, newRock, true);
            gestureNames.Add(newSpock);
        }
    }
}
