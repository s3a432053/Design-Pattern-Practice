using BuilderPattern.CarExample;
using BuilderPattern.CarExample.BuilderDocument;
using BuilderPattern.CarExample.CarDocument;
using BuilderPattern.MealExample.MealDocument;

// Builder
MealBuilder mealBuilder = new MealBuilder();

// 取得 透過 Builder 創建的 素食Meal
Meal vegMeal = mealBuilder.PrepareVegMeal();
Console.WriteLine("Veg Meal");
vegMeal.ShowItems();
Console.WriteLine("Total Cost: " + vegMeal.GetCost());

// 取得 透過 Builder 創建的 非素食Meal
Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
Console.WriteLine("\n\nNon-Veg Meal");
nonVegMeal.ShowItems();
Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());

Console.WriteLine("\n-------------分隔線-------------\n");

// Director
Director director = new();

// 使用 CarBuilder 建立 SportCar
CarBuilder carBuilder = new();
director.ConstructSportsCar(carBuilder);

// 使用 CarManualBuilder 建立 SUVCar
CarManualBuilder carManualBuilder = new();
director.ConstructSUV(carManualBuilder);

// 取得 Car
Car car = carBuilder.GetResult();
Console.WriteLine($"Car Seat：{car.Seat}、Car Engine：{car.Engine}、Car TripComputer：{car.TripComputer}、Car GPS：{car.GPS}");

// 取得 ManulCar
CarManual carManul = carManualBuilder.GetResult();
Console.WriteLine($"\nCarManual Seat：{carManul.Seat}、CarManual Engine：{carManul.Engine}、CarManual TripComputer：{carManul.TripComputer}、CarManual GPS：{carManul.GPS}");