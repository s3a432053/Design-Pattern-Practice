using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Fly
{
    public class LowFly : IFly
    {
        public void Fly(string name)
        {
            Console.WriteLine($"{name} 低空飛翔");
        }
    }
}
