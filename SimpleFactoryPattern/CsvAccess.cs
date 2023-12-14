using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    // Csv 存取
    public class CsvAccess : IAccess
    {
        public List<int> GetAllCost()
        {
            return new List<int>() { 4,5,6 };
        }
    }
}
