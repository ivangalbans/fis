using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Fuzzy.Function;

namespace Fuzzy.Defuzzifier
{
    public static class Defuzzifier
    {
        /// <summary>
        /// Determine the center of gravity (centroid) of a function's curve
        /// </summary>
        /// <param name="function">Function object</param>
        /// <param name="step">Distance between domain's values</param>
        /// <returns>Numeric value representing the domain's value which approximately corresponds to the centroid</returns>
        public static double Centroid(FunctionBase function, double step = 0.1)
        {
            var points = function.Points(step);
            (double num, double den) = (0, 0);

            foreach (var (x, y) in points)
            {
                num += x * y;
                den += y;
            }

            return num / den;
        }

        /// <summary>
        /// Determine the center of area (splits the curve in two pices with the same area) (bisecter) of a function
        /// </summary>
        /// <param name="function">Function object</param>
        /// <param name="step">Distance between domain's values</param>
        /// <returns>Numeric value representing the domain's value which approximately corresponds to the bisecter</returns>
        public static double Bisecter(FunctionBase function, double step = 0.1)
        {
            var points = function.Points(step);
            double area = points.Select((x, y) => y).Sum();

            double current = 0.0;
            foreach(var (x, y) in points)
            {
                current += y;
                if (current >= area / 2.0)
                    return x;
            }
            throw new Exception("There is some error");
        }

        /// <summary>
        /// Determine the point which corresponds with the mean of the function's maximums
        /// </summary>
        /// <param name="func">Function object</param>
        /// <param name="step">Distance between domain's values</param>
        /// <returns>Numeric value representing the domain's value which approximately corresponds to the mean of maximums</returns>
        public static double MeanMax(FunctionBase function, double step = 0.1)
        {
            var points = function.Points(step);
            var maximums = new List<double>();
            double k = 0;

            foreach(var (x, y) in points)
            {
                if (Math.Abs(y - k) < 1e-6)
                {
                    maximums.Add(x);
                }
                else if(y > k)
                {
                    k = y;
                    maximums.Clear();
                    maximums.Add(x);
                }
            }

            return maximums.Sum() / maximums.Count();
        }
    }
}
