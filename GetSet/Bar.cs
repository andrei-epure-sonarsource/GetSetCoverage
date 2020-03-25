﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    public class Bar
    {
        public int CoveredGet { get; set; } public int UncoveredProperty { get; set; } public int CoveredSet { get; set; }

        public int CoveredGetOnSecondLine { get; set; }

        public int CoveredProperty { get; set; }

        public int ArrowMethod(bool condition) => condition ? CoveredGetOnSecondLine : UncoveredProperty;

        public int BodyMethod()
        {
            var x = CoveredProperty; CoveredProperty = 1; goto label; UncoveredProperty = 1;

            UncoveredProperty = 1;

            label:
            CoveredSet = 1;

            return CoveredGet;
        }
    }
}
