using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy.Function
{
    /// <summary>
    /// Represents the composition of several functions
    /// </summary>
    public class Compose : FunctionBase
    {
        List<(object w, FunctionBase function)> aggr;

        /// <summary>
        /// Initialize a new composed function
        /// </summary>
        /// <param name="aggr">List of tuples (trunc, function) where trunc is an upper limit to func's image</param>
        public Compose(List<(object trunc, FunctionBase function)> aggr) :
            base(aggr.Aggregate((x, y) => (x.function._start < y.function._start) ? x : y).function._start,
                 aggr.Aggregate((x, y) => (x.function._start > y.function._start) ? x : y).function._end)
        {
            this.aggr = aggr;
        }

        public override double Evaluate(double x)
        {
            // Check produced image of each member function and keep the greatest
            double y = 0;
            foreach( (var trunc, var func) in aggr)
            {
                double yi = Math.Min((double)trunc, func.Evaluate(x));  // Trunc function if necessary
                y = Math.Max(y, yi);
            }
            return y;
        }
    }
}
