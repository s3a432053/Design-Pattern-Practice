using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SimpleThreadSafetySingleton
    {
        private static readonly object padlock = new object();

        private static SimpleThreadSafetySingleton _instance = null;

        private SimpleThreadSafetySingleton()
        {
        }

        public static SimpleThreadSafetySingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleThreadSafetySingleton();
                    }
                    return _instance;
                }
            }
        }
    }
}
