using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowPricer.Utilities
{
    public  class RatesSpreadsUtility
    {
        public double[] ConvertSwapRatesToZero(double[] swapRates)
        {
            List<double> zeroRates = new List<double>();
            foreach (var item in swapRates)
            {
                zeroRates.Add(item * 2);
            }
            return zeroRates.ToArray();
        }

    }
}
