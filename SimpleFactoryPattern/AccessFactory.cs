using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    // 存取實體 工廠
    public class AccessFactory
    {
        // 建立 存取實體
        public static IAccess Create(string category)
        {
            switch (category)
            {
                case "sql":
                    return new SQLAccess();
                case "csv":
                    return new CsvAccess();
            }

            return null;
        }
    }
}
