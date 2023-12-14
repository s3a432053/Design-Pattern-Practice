﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 測試型別，對實現部分進行抽象
    /// </summary>
    public abstract class TestType
    {
        public string Name { get; set; }

        public Double RunTime { get; set; }

    }
}
