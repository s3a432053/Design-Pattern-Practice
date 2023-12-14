using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 公司，對實現部分進行抽象
    /// </summary>
    public abstract class Company
    {
        public string Name { get; set; }

        public Double BaseTime { get; set; }

    }
}
