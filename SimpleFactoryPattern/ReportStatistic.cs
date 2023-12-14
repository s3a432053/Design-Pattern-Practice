using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    public class ReportStatistic
    {
        // 存取資料實體
        private readonly IAccess _access = null;

        public ReportStatistic(string accessType)
        {
            // 依據 accessType 來從 工廠產生 存取實體
            _access = AccessFactory.Create(accessType);
        }

        // 加總透過存取實體取得的 Data
        public int Sum()
        {
            var items = _access.GetAllCost();
            return items.Sum();
        }
    }
}
