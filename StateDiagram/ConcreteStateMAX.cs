using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagram
{
    // 等級 90~
    public class ConcreteStateMAX : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level >= 90)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "神");
            }
        }
    }

}
