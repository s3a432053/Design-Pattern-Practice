
////字面上理解委託，就像是A委託B去辦一件事情一樣
//// WriteSometing 請 PrintNumber 處理事情
//using static Test.DelegateTest;

//toSometing delegateTestA = new(PrintNum);//傳統寫法            

//delegateTestA += RadicalFunction;
//delegateTestA += PrintNum;
//delegateTestA += SquareFunction;
//delegateTestA(25);

//Console.WriteLine("====以下另一個委任====");
//toSometing b = PrintNum;     //語法糖
//b(88);

//Console.WriteLine("按任意鍵結束....");
//Console.ReadKey();  //可按任意鍵結束畫面


using Test;

ForTest forTest = new();

List<int> inputForFindClosestNumbers2 = new() { 6, 2, 4, 10 };
forTest.FindClosestNumbers2(inputForFindClosestNumbers2);
List<int> inputForDestroyPlane = new() { 2, 4, 6, 3, 4 };
int result = forTest.DestroyPlane(inputForDestroyPlane);
Console.WriteLine(result);
Console.ReadKey();  //可按任意鍵結束畫面                                       