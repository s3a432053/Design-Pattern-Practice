using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // 策略介面
    public interface IStrategy
    {
        // 計算
        public int calculate(int a, int b);
    }
}
