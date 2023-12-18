using BuilderPattern.MealExample.MealDocument;

MealBuilder mealBuilder = new MealBuilder();

Meal vegMeal = mealBuilder.PrepareVegMeal();
Console.WriteLine("Veg Meal");
vegMeal.ShowItems();
Console.WriteLine("Total Cost: " + vegMeal.GetCost());

Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
Console.WriteLine("\n\nNon-Veg Meal");
nonVegMeal.ShowItems();
Console.WriteLine("Total Cost: " + nonVegMeal.GetCost());