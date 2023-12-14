using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagram
{
    // 等級 20~50
    public class ConcreteState050 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 50)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "老手");
            }
            else
            {
                // 改變狀態 成 50 ~ 89 等
                user.setStateContext(new ConcreteState090());
                // 執行 50 ~ 89 等的狀態內容
                user.stateWork();
            }
        }
    }
}
