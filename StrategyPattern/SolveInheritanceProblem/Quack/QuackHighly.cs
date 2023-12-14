using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem.Quack
{
    public class QuackHighly : IQuackable
    {
        public void Quack(string name)
        {
            Console.WriteLine($"{name} 高音叫");
        }
    }
}
