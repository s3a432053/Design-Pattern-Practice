using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // 加法策略
    public class Add : IStrategy
    {
        public int calculate(int a, int b)
        {
            return a + b;
        }
    }
}
