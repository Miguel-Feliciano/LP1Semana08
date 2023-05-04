using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnits
{
    class SettlerUnit : Unit
    {
        public override float Cost => 5.0f;

        public SettlerUnit() : base(2, 1) 
        { 
            
        }
    }
}