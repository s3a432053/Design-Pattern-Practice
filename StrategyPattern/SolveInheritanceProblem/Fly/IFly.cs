using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Fly
{
    // Fly 策略
    public interface IFly
    {
        public void Fly(string name);
    }
}
