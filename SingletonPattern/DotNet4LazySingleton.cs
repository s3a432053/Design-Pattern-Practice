using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class DotNet4LazySingleton
    {
        private static readonly Lazy<DotNet4LazySingleton> lazy = new(() => new DotNet4LazySingleton());

        private DotNet4LazySingleton()
        {
        }

        public static DotNet4LazySingleton Instance { get { return lazy.Value; } }
    }
}
