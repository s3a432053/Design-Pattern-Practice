using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 存取介面
    /// </summary>
    public interface IAccess
    {
        List<int> GetAllCost();
    }
}
