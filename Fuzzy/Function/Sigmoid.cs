using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy.Function
{
    public class Sigmoid : Function
    {
        protected double k, x0;
        public Sigmoid(double k, double x0) : base(-Math.Abs(6.0 / k), Math.Abs(6.0 / k)) // Wiki ;)
        {
            this.k = k; // width
            this.x0 = x0; // center
        }

        public override double Evaluate(double x)
        {
            return 1.0 / (1.0 + Math.Pow( Math.E, ( -k * (x - x0) ) ));
        }
    }
}
