using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDiagram
{
    // 玩家
    public class Player
    {
        public int level = 1; // 等級

        // 玩家狀態
        // 1 ~ 20 等  => 新手
        // 21 ~ 49 等 => 老手
        // 50 ~ 89 等 => 高手
        // >= 90 等   => 神
        private StateContext state;

        public Player()
        {
            // 初始化狀態處理的物件
            setStateContext(new ConcreteState001());
        }

        // 設定狀態處理的物件
        public void setStateContext(StateContext s)
        {
            state = s;
        }

        // 狀態處理，轉交由 StateContext 物件處理
        public void stateWork()
        {
            state.stateWork(this);
        }

        public void oldStateWork()
        {
            if (level <= 20)
            {
                Console.WriteLine($"等級 {level} (新手)");
            } 
            else if (level < 50)
            {
                Console.WriteLine($"等級 {level} (老手)");
            }
            else if (level < 90)
            {
                Console.WriteLine($"等級 {level} (高手)");
            }
            else
            {
                Console.WriteLine($"等級 {level} (神)");
            }
        }
    }
}
