using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy.Function
{
    /// <summary>
    /// Generic function representation
    /// </summary>
    public abstract class FunctionBase
    {
        public double? _start, _end;

        /// <summary>
        /// Initialize a new function object
        /// </summary>
        /// <param name="start">First 'relevant' value in the function's domain</param>
        /// <param name="end">Last 'relevant' value in the function's domain</param>
        public FunctionBase(double? start, double? end)
        {
            _start = start;
            _end = end;
        }

        /// <summary>
        /// Generator of tuples (x, f(x)) in the interval [self.start, self.end]
        /// </summary>
        /// <param name="step">Distance between points in the discretized function domain</param>
        public IEnumerable<(double x, double y)> Points(double step = 0.1)
        {
            var x = _start ?? 0.0;
            while (x < _end)
            {
                yield return (x, Evaluate(x));
                x += step;
            }
        }

        public abstract double Evaluate(double x);

    }
}
