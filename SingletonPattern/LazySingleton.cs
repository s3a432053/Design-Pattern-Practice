using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class LazySingleton
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get
            {
                return InnerClass.Instance;
            }
        }

        private class InnerClass
        {
            internal static readonly LazySingleton Instance = new LazySingleton();

            static InnerClass()
            {
            }
        }
    }
}
