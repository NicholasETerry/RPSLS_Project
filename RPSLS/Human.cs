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


        // CONSTRUCTOR ( SPAWNER )
        public Human()
        {
        int realIndexValue = Input.gestureIndex - 1;
            HumanGamePlay();
            Console.WriteLine("'Did this work");
            Console.ReadLine();
        }
        public void HumanGamePlay()
        {

        }
        // MEMBER METHOD ( CAN DO )
    }
}
