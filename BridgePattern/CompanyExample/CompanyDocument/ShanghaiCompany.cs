using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.CompanyExample.CompanyDocument
{
    /// <summary>
    /// 公司抽象類具體實現，具體實現化角色
    /// </summary>
    public class ShanghaiCompany : Company
    {
        public ShanghaiCompany()
        {
            Name = "上海公司";
            BaseTime = 100;
        }
    }
}
