using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        //As a player, i want correct player to win a given round based on the choices made by each player
        //As a player, i want the game to be a minimum of 'best of three' to decide a winner
        //As a player, i wnat the option of a single player or multiplayer game

        // MEMBER VARIABLE ( HAVE A )


        // CONSTRUCTOR ( SPAWNER )
        public Player()
        {

        }
        public virtual void CreatePlayer()
        {

        }
        // MEMBER METHOD ( CAN DO )
        public virtual void ChooseAGesture(Gestures yourChoice)
        {

        }
    }
}
