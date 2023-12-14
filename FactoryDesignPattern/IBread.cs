using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    // 麵包 Interface
    public interface IBread
    {
        // 麵包名稱
        string Name { get; set; }
        // 取得麵包名稱
        string GetBreadName();
    }
}
