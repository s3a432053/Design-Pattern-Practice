namespace StrategyPattern.SolveFatCodeProblem
{
    // 加法策略
    public class Add : IStrategy
    {
        public int calculate(int a, int b)
        {
            return a + b;
        }
    }
}
