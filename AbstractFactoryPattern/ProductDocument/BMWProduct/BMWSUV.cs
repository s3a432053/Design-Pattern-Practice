﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern.ProductDocument.BMWProduct
{
    // BMW 的 SUV
    public class BMWSUV : BMW
    {
        public BMWSUV()
        {
            setType("SUV");
        }
    }
}
