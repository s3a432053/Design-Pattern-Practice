using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveFatCodeProblem
{
    // 除法策略
    public class Divide : IStrategy
    {
        public int calculate(int a, int b)
        {
            return a / b;
        }
    }
}
