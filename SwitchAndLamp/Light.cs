using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndLamp
{
    public class Light : ISwitchable
    {
        public void TurnOn()
        {
            Console.WriteLine("Lamp is ON");
        }

        public void TurnOff()
        {
            Console.WriteLine("Lamp is OFF");
        }
    }
}
