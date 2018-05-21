using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fuzzy.Function;

namespace Fuzzy.Defuzzifiers
{
    public static class Defuzzifiers
    {
        /// <summary>
        /// Determine the center of gravity (centroid) of a function's curve
        /// </summary>
        /// <param name="func">Function object</param>
        /// <param name="step">Distance between domain's values</param>
        /// <returns>Numeric value representing the domain's value which approximately corresponds to the centroid</returns>
        public static double Centroid(FunctionBase func, double step = 0.1)
        {
            var points = func.Points();
            (double num, double den) = (0, 0);

            foreach (var (x, y) in points)
            {
                num += x * y;
                den += y;
            }

            return num / den;
        }
    }
}
