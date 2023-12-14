using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class ObjectC
    {
        public void ObjCGreeting(ObjectA objectA)
        {
            Console.WriteLine("I love you, " + objectA.Name + ". This is Object C.");
        }
    }
}
