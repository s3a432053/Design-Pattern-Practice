using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.CompanyExample.TestDocument
{
    /// <summary>
    ///測試型別抽象類具體實現，具體實現化角色
    /// </summary>
    public class AutoTest : TestType
    {
        public AutoTest()
        {
            Name = "自動測試";
            RunTime = 10;
        }
    }
}
