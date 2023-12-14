using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagram
{
    // 狀態模式的抽象類別
    public abstract class StateContext
    {
        public abstract void stateWork(Player user);
    }
}
