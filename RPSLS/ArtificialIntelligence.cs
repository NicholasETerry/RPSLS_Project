using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class ArtificialIntelligence : Player
    {
        Random newRad = new Random();
        int PlayerOneRealIndexValue;
        int PlayerTwoRealIndexValue;
        // MEMBER VARIABLE ( HAVE A )
        // TO DO
        // AI selected random gesture to play against human.

        // CONSTRUCTOR ( SPAWNER )
        public ArtificialIntelligence()
        {
            PlayerOneRealIndexValue = (Convert.ToInt32(Input.gestureIndex)) - 1;
            PlayerTwoRealIndexValue = newRad.Next(0, Game.gestureNames.Count());
            AIGamePlay();
        }

        // MEMBER METHOD ( CAN DO )

        public void AIGamePlay()
        {
            while (Game.playerOneGameScore < 2 && Game.playerTwoGameScore < 2)
            {
                bool didWin = false;
                foreach (var item in Game.gestureNames[PlayerOneRealIndexValue].WinningGesture)
                {
                    if (item == Game.gestureNames[PlayerTwoRealIndexValue])
                    {
                        Console.WriteLine("player one wins");  // for testing
                        Game.playerOneGameScore++;
                        didWin = true;
                    }
                }
                foreach (var item in Game.gestureNames[PlayerOneRealIndexValue].LoosingGesture)
                {
                    if (item == Game.gestureNames[PlayerTwoRealIndexValue])
                    {
                        Console.WriteLine("player two wins");  // for testing
                        Game.playerTwoGameScore++;
                        didWin = true;
                    }

                }
                if (didWin == false)
                {
                    Console.WriteLine("The round ended in a tie");
                }
                if (Game.playerOneGameScore < 2 && Game.playerTwoGameScore < 2)
                {
                    Console.WriteLine("player one score : " + Game.playerOneGameScore);
                    Console.WriteLine("player two score : " + Game.playerTwoGameScore);
                    Console.ReadLine();
                    Input.HumanVsAIGestureSelection();
                }
                else if (Game.playerOneGameScore == 2 || Game.playerTwoGameScore == 2) // THIS KIND OF ELEMINATES THE NEED FOR THE WHILE LOOP
                {
                    Input.EndOfGame();
                }
                //Input.HumanVsHumanGestureSelection();
                //HumanGamePlayGetSecondPlayer();
            }
        }
    }
}
