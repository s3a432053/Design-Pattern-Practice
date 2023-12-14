using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class EagerSingleton
    {
        private EagerSingleton()
        {
        }

        public static EagerSingleton Instance { get; } = new EagerSingleton();
    }
}
