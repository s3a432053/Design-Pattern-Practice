
using StrategyPattern;

// 宣告計算機
Calculator calculator = new();
// 設定計算方式
calculator.SetStrategy(new Add());
// 執行計算
Console.WriteLine(calculator.Execute(10, 20));
Console.ReadLine();

// 舊寫法
Console.WriteLine(calculator.OldExecute("Add", 10, 20));
Console.ReadLine();