using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class DoubleCheckedLockingSingleton
    {
        private static readonly object padlock = new object();
        private static DoubleCheckedLockingSingleton _instance = null;

        //用來LOCK建立instance的程序。
        public static DoubleCheckedLockingSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedLockingSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
