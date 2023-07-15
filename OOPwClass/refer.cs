using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPwClass
{

    class UnitConversion
    {
        public string FromUnit { get; }
        public string ToUnit { get; }
        public Func<double, double> ConversionFunc { get; }

        public UnitConversion(string fromUnit, string toUnit, Func<double, double> conversionFunc)
        {
            FromUnit = fromUnit;
            ToUnit = toUnit;
            ConversionFunc = conversionFunc;
        }
    }
}
