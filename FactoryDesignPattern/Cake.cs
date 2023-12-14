﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    // 繼承 麵包介面 的 蛋糕
    public class Cake : IBread
    {
        // 蛋糕名稱
        public string Name { get; set; }
        // 蛋糕形狀
        public string Shape { get; set; }
        // 建構子 設定蛋糕名稱
        public Cake(string name)
        {
            Name = name;
        }
        // 取得蛋糕名稱
        public string GetBreadName()
        {
            return $"Cake: {this.Name}";
        }
        // 取得蛋糕形狀
        public string GetShape()
        {
            return $"* Cake's shape: {this.Shape}";
        }
    }
}
