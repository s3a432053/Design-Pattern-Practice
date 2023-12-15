using BridgePattern.CompanyExample.CompanyDocument;
using BridgePattern.CompanyExample.TestDocument;

namespace BridgePattern.CompanyExample.ProductDocument
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
