using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
     abstract class Gestures
    {
        // MEMBER VARIABLE ( HAVE A )
        // if Gesture does not appear in either list. Assume both gesutres are equal
        public List<Gestures> WinningGesture = new List<Gestures>();
        public List<Gestures> LoosingGesture = new List<Gestures>();
        public string gestureName;
        // CONSTRUCTOR ( SPAWNER )
        public Gestures()
        {
            // GESTURE NEVER GETS CONSTRUCTED
        }

        // MEMBER METHOD ( CAN DO )

        // Gesture needs to be able to be compaired to another gesture to determine which gesture is stronger
        public virtual void CreateGesture(Gestures name,Gestures against, bool isNameStrongerThenAgainst)
        {
            // JUST CREATE GESTURE. NOTHING ELSE
            if(isNameStrongerThenAgainst == true)
            {
                WinningGesture.Add(against);
            }
            else if(isNameStrongerThenAgainst == false)
            {
                LoosingGesture.Add(against);
            }
        }

    
    }
}
