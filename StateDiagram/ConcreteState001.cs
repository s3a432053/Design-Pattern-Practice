using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagram
{
    // 等級 1~20
    public class ConcreteState001 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 20)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "新手");
            }
            else
            {
                // 改變狀態 成 21 ~ 49 等
                user.setStateContext(new ConcreteState050());
                // 執行 21 ~ 49 等的狀態內容
                user.stateWork();
            }
        }
    }
}
