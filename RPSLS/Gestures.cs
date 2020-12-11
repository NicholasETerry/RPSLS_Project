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
            // ABSTRACT CLASSES CAN USE CONSTRUCTERS
        }

        // MEMBER METHOD ( CAN DO )

        public virtual void CreateGesture(Gestures name,Gestures against, bool isNameStrongerThenAgainst)
        {
            // CREATE GESTURE AND ADD TO LIST
            if(isNameStrongerThenAgainst == true)
            {
                WinningGesture.Add(against);
            }
            else if(isNameStrongerThenAgainst == false)
            {
                LoosingGesture.Add(against);
            }
        }
        public virtual void DisplayItemsInList( List<Gestures> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(items.Count());

        }

    
    }
}
