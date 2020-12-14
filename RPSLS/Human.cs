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

            PlayerOneRealIndexValue = Input.gestureIndex - 1;
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
            PlayerTwoRealIndexValue = Convert.ToInt32(Console.ReadLine()) - 1 ;
        }
        public void CompairGestures()
        {
            foreach (var item in Game.gestureNames[PlayerOneRealIndexValue].WinningGesture)
            {
                Console.WriteLine(item);
            }
        } 
        // MEMBER METHOD ( CAN DO )
    }
}
