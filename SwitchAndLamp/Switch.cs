using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchAndLamp
{
    public class Switch
    {
        private readonly ISwitchable switchable;
        private bool isOn = false;

        Switch (ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Toggle()
        {
            isOn = !isOn;
            if (isOn)
            {
                switchable.TurnOn();
            }
            else
            {
                switchable.TurnOff();
            }
        }
    }
}
