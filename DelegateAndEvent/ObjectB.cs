using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class ObjectB
    {
        public void ObjBGreeting(ObjectA objectA)
        {
            Console.WriteLine("Hello, " + objectA.Name + ". This is Object B.");
        }
    }
}
