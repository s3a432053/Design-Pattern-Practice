using BridgePattern.CompanyExample.CompanyDocument;
using BridgePattern.CompanyExample.TestDocument;

namespace BridgePattern.CompanyExample.ProductDocument
{
    /// <summary>
    /// 管理系統，擴充套件抽象化角色
    /// </summary>
    public class ManagementProdeuct : Prodeuct
    {

        public ManagementProdeuct(Company company, TestType testType) : base(company, testType)
        {
            Name = "管理系統";
        }
    }
}
