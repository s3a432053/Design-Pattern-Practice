using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    ///測試型別抽象類具體實現，具體實現化角色
    /// </summary>
    public class ManualTest : TestType
    {
        public ManualTest()
        {
            Name = "手工測試";
            RunTime = 30;
        }
    }
}
