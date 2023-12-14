using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Swim
{
    // 游泳 策略
    public interface ISwimable
    {
        public void Swim(string name);
    }
}
