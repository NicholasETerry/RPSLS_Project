using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        // MEMBER VARIABLE ( HAVE A )
        int PlayerOneRealIndexValue;
        int PlayerTwoRealIndexValue;
        // CONSTRUCTOR ( SPAWNER )
        public Human()
        {
            // At this point, player one has made a gesture choice
            //TO DO !
            // I need to get player two gesture
            // both gestures face off to see who wins
            // game will end when a player has won 2 matches

            PlayerOneRealIndexValue = (Convert.ToInt32(Input.gestureIndex)) - 1;
            HumanGamePlayGetSecondPlayer();
            CompairGestures();
        }
        public void HumanGamePlayGetSecondPlayer()
        {
            int i = 1;
            Console.WriteLine(" Player Two: Choose your best Gesture !\n" +
                "These are your choices.\n");
            foreach (var item in Game.gestureNames)
            {

                Console.WriteLine("For " + item + ": Press " + i);
                i++;
            }
            Input.gestureIndex = (Console.ReadKey(true).KeyChar).ToString();
            PlayerTwoRealIndexValue = (Convert.ToInt32(Input.gestureIndex)) - 1 ;
        }
        public void CompairGestures()
        {
            foreach (var item in Game.gestureNames[PlayerOneRealIndexValue].WinningGesture)
            {
                if (item == Game.gestureNames[PlayerTwoRealIndexValue])
                {
                    Console.WriteLine("player one wins");  // for testing
                    Console.ReadLine();
                }
            }
            foreach (var item in Game.gestureNames[PlayerOneRealIndexValue].LoosingGesture)
            {
                if (item == Game.gestureNames[PlayerTwoRealIndexValue])
                {
                    Console.WriteLine("player two wins");  // for testing
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The game was a tie");  // for testing
                    Console.ReadLine();
                }
            }

        } 
        // MEMBER METHOD ( CAN DO )
    }
}
