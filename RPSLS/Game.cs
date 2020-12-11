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
        // MEMBER VARIABLE ( HAVE A )


        // CONSTRUCTOR ( SPAWNER )
        public Game()
        {


            foreach (var item in newRock.WinningGesture)
            {
                Console.WriteLine(item);
                Console.WriteLine("Rock wins against these");
                Console.ReadLine();
            }
            foreach (var item in newRock.LoosingGesture)
            {
                Console.WriteLine(item);
                Console.WriteLine("Rock looses against these");
                Console.ReadLine();
            }
        }
        public void MakeRocks()
        {
            newRock.CreateGesture(newRock, newScissors, true);
            newRock.CreateGesture(newRock, newPaper, false);
            newRock.CreateGesture(newRock, newLizard, true);
            newRock.CreateGesture(newRock, newSpock, false);
        }
        // MEMBER METHOD ( CAN DO )
    }
}
