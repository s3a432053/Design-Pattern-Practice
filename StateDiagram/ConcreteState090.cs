using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagram
{
    // 等級 50~90
    public class ConcreteState090 : StateContext
    {
        public override void stateWork(Player user)
        {
            if (user.level < 90)
            {
                Console.WriteLine("等級 {0} ({1})", user.level, "高手");
            }
            else
            {
                // 改變狀態 成 >= 90 等
                user.setStateContext(new ConcreteStateMAX());
                // 執行 >= 90 等的狀態內容
                user.stateWork();
            }
        }
    }
}
