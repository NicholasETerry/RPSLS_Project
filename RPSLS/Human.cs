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
            while (Input.wasStringGood == false)
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
                Input.wasStringGood = int.TryParse(Input.gestureIndex, out Input.wasNumberGood);
         
                if (Input.wasStringGood == false)
                {
                    Console.WriteLine("\nInvalid entry. Please try again.");
                }
            }
            Input.wasStringGood = false;
        }
        public void CompairGestures()
        {
            //while(Game.playerOneGameScore < 2 &&  Game.playerTwoGameScore < 2)
            //{
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
                    Input.HumanVsHumanGestureSelection();
                    if(Game.playerTwoGameScore == 2)
                    {
                    
                    }
                    else
                    {
                    HumanGamePlayGetSecondPlayer();
                    }    
                }
                else if(Game.playerOneGameScore ==2 || Game.playerTwoGameScore == 2) // THIS KIND OF ELEMINATES THE NEED FOR THE WHILE LOOP
                {
                    Input.EndOfGame();
                }

        } 
        //public void EndOfGame()
        //{
        //    if(Game.playerOneGameScore == 2)
        //    {
        //        Console.WriteLine("Congrats ! Player One Wins.");
        //    }
        //    else if (Game.playerTwoGameScore == 2)
        //    {
        //        Console.WriteLine(" Comgrats ! Player Two Wins.");
        //    }
        //    Console.WriteLine("Would you like to play again ?\n" +
        //        "Press 1 to play again:\n" +
        //        "Press any other key to exit:");
        //    int choiceEntered = Convert.ToInt32(Console.ReadKey(true).Key);
        //    if(choiceEntered == 49)
        //    {
        //        Game newGame = new Game();

        //    }
        //}
        // MEMBER METHOD ( CAN DO )
    }
}
