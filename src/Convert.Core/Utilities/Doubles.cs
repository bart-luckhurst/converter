using System;
using System.Collections.Generic;
using System.Text;

namespace Convert.Core.Utilities
{
    public static class Doubles
    {

        public static double RoundToSignificantFigures(this double d, int digits)
        {
            // Shocked to realise .NET Standard doesn't have a "round to x significant figures" method, so using this:
            //https://stackoverflow.com/questions/374316/round-a-double-to-x-significant-figures
            if (d == 0)
            {
                return 0;
            }

            decimal scale = (decimal)Math.Pow(10, Math.Floor(Math.Log10(Math.Abs(d))) + 1);

            return (double)(scale * Math.Round((decimal)d / scale, digits));
        }
    }
}
