using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveFatCodeProblem
{
    // 計算機
    public class Calculator
    {
        // 策略介面
        private IStrategy _strategy;

        // 執行策略
        public int Execute(int a, int b)
        {
            return _strategy.calculate(a, b);
        }

        // 設定策略
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
