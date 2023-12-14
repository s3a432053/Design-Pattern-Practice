using StrategyPattern.SolveInheritanceProblem.Fly;
using StrategyPattern.SolveInheritanceProblem.Quack;
using StrategyPattern.SolveInheritanceProblem.Swim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.SolveInheritanceProblem
{
    public class Duck
    {
        private readonly IQuackable _quackable;
        private readonly ISwimable _swimable;
        private readonly IFly _fly;
        private readonly string _duckName;

        public Duck(
            string duckName,
            IQuackable quackable,
            ISwimable swimable,
            IFly fly)
        {
            _quackable = quackable;
            _duckName = duckName;
            _swimable = swimable;
            _fly = fly;
        }

        public void Quack()
        {
            _quackable.Quack(_duckName);
        }

        public void Swim()
        {
            _swimable.Swim(_duckName);
        }

        public void Fly()
        {
            _fly.Fly(_duckName);
        }
    }
}
