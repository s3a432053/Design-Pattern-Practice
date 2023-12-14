using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Quack
{
    // 鴨叫 策略
    public interface IQuackable
    {
        public void Quack(string name);
    }
}
