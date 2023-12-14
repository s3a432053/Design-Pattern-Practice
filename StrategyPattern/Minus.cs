using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // 減法策略
    public class Minus : IStrategy
    {
        public int calculate(int a, int b)
        {
            return a - b;
        }
    }
}
