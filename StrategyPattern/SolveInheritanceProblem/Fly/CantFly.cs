using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Fly
{
    public class CantFly : IFly
    {
        public void Fly(string name)
        {
            Console.WriteLine($"{name} 不會飛");
        }
    }
}
