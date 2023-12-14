using StrategyPattern.SolveFatCodeProblem;
using StrategyPattern.FatCodeProblem;
using StrategyPattern.InheritanceProblem;
using StrategyPattern.SolveInheritanceProblem;
using StrategyPattern.SolveInheritanceProblem.Quack;
using StrategyPattern.SolveInheritanceProblem.Swim;
using StrategyPattern.SolveInheritanceProblem.Fly;

// 程式碼肥大問題寫法
Console.WriteLine("程式碼肥大問題寫法：");
FatCalculator fatCalculator = new();
Console.WriteLine(fatCalculator.Execute("Add", 10, 20));
Console.ReadLine();

Console.WriteLine("程式碼肥大問題 使用策略模式後的樣子：");
// 程式碼肥大問題 使用策略模式後的樣子
// 宣告計算機
Calculator calculator = new();
// 設定計算方式
calculator.SetStrategy(new Add());
// 執行計算
Console.WriteLine(calculator.Execute(10, 20));
Console.ReadLine();

Console.WriteLine("繼承問題寫法：");
// 繼承問題寫法
ProblemParentDuck cityDuck = new CityDuck();
cityDuck.Quack();
cityDuck.Swim();
cityDuck.Fly();
ProblemParentDuck wildDuck = new WildDuck();
wildDuck.Quack();
wildDuck.Swim();
wildDuck.Fly();
ProblemParentDuck fakeDuck = new FakeDuck();
fakeDuck.Quack();
fakeDuck.Swim();
fakeDuck.Fly();
Console.ReadLine();

Console.WriteLine("繼承問題 使用策略模式後的樣子：");
// 繼承問題 使用策略模式後的樣子
Duck cityDuck2 = new("城市鴨",
                     new QuackHighly(),
                     new WaterUpSwim(),
                     new LowFly());
cityDuck2.Quack();
cityDuck2.Swim();
cityDuck2.Fly();
Duck wildDuck2 = new("野鴨",
                     new QuackLowly(),
                     new WaterDownSwim(),
                     new HighFly());
wildDuck2.Quack();
wildDuck2.Swim();
wildDuck2.Fly();
Duck fakeDuck2 = new("假鴨",
                     new CantQuack(),
                     new CantSwim(),
                     new CantFly());
fakeDuck2.Quack();
fakeDuck2.Swim();
fakeDuck2.Fly();
Console.ReadLine();