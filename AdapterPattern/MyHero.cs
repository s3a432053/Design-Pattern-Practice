using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    // 自家遊戲 英雄實體
    internal class MyHero : IHero
    {
        public void Attack()
        {
            Console.WriteLine("My hero attack");
        }
    }
}
