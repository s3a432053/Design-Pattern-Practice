using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent
{
    class ObjectA
    {
        public string Name { get; set; }

        // 委派
        public delegate void ObjADelegate(ObjectA objectA);
        // 事件 => 觸發後要執行 ObjADelegate 委派
        public event ObjADelegate ObjAnounceEvent;

        public ObjectA(string name)
        {
            Name = name;
        }

        public void OnObjAEventBeenCalled()
        {
            ObjAnounceEvent?.Invoke(this);
        }
    }
}
