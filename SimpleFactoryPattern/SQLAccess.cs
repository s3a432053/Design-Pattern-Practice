using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    // Sql 存取
    public class SQLAccess : IAccess
    {
        public List<int> GetAllCost()
        {
            return new List<int>() { 1,2,3 };
        }
    }
}
