namespace StrategyPattern.FatCodeProblem
{
    // 計算機
    public class FatCalculator
    {
        // 舊寫法
        public int Execute(string doType, int a, int b)
        {
            return doType switch
            {
                "Add" => a + b,
                "Minus" => a - b,
                "Multyply" => a * b,
                "Divide" => a / b,
                _ => 0,
            };
        }
    }
}
