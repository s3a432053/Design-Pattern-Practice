using PrototypePattern.DeepClone;
using PrototypePattern.ShallowClone;

// 淺複製
Console.WriteLine("ShallowClone：\n");
ShallowApp shallowApp = new();
shallowApp.Run();

// 深複製
Console.WriteLine("\nDeepClone：\n");
DeepApp deepApp = new();
deepApp.Run();