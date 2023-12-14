using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 軟體產品，抽象類
    /// 充當抽象化角色
    /// 將抽象部分與實現部分分離，使他們都可以獨立的變化
    /// </summary>
    public abstract class Prodeuct
    {
        private readonly Company _company;
        private readonly TestType _testType;

        // 使用組合，一個產品外包出去，需要一個公司進行不同測試型別的測試
        public Prodeuct(Company company, TestType testType)
        {
            this._company = company;
            this._testType = testType;
        }

        public string Name { get; set; }

        // 執行實現部分
        public void Run()
        {
            Console.WriteLine($"{this._company.Name}對產品{Name}進行{this._testType.Name},總共花費時間{this._company.BaseTime + this._testType.RunTime}。");
            Console.WriteLine("======================================================");
        }

    }
}
