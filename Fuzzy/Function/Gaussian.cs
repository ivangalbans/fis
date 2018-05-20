using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy.Function
{
    public class Gaussian : Function
    {
        double b, c;
        public Gaussian(double b, double c) : base(-Math.Abs(6.0 * c), -Math.Abs(6.0 * c))
        {
            this.b = b; // center
            this.c = c; // width
        }

        public override double Evaluate(double x)
        {
            return Math.Pow(Math.E, -( Math.Pow(x - b, 2) / (2 * c*c) ) );
        }

    }
}
