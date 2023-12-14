using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class DelegateTest
    {
        //我們習慣把數據或者對像作為參數傳遞給方法，
        //比如：  int i = int.Parse("99");
        //如果我們把方法作為參數傳遞給方法，這就需要用到委託了
        public delegate void toSometing(int number);
        //C#中委託的參數和返回類型，都要和你要具體委託的方法要一致

        public static void PrintNum(int number) //預計要被傳遞的方法
        {
            Console.WriteLine($"PrintNumber:{number}");
        }

        public static void SquareFunction(int number) // print數字的平方
        {
            Console.WriteLine($"SquareFunction:{Math.Pow(number, 2)}");
        }

        public static void RadicalFunction(int number)// print數字開根號
        {
            Console.WriteLine($"RadicalFunction:{Math.Sqrt(number)}");
        }
    }
}
