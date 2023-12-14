using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 運營系統，擴充套件抽象化角色
    /// </summary>
    public class OperationProdeuct : Prodeuct
    {

        public OperationProdeuct(Company company, TestType testType) : base(company, testType)
        {
            Name = "運營系統";
        }
    }
}
