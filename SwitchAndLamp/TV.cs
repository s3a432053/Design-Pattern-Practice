using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndLamp
{
    public class TV : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("TurnOn the TV");
        }
        public void TurnOff()
        {
            Console.WriteLine("TurnOff the TV");
        }
    }
}
