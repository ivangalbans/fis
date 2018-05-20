﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy.Function
{
    public class Trapezoid : Function
    {
        protected double? a, b, c, d;
        public Trapezoid(double start, double end, double? a, double? b, double? c = null, double? d = null) : base(start, end)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;

        }

        public override double Evaluate(double x)
        {
            if(!(a is null))
            {
                if (x <= a)
                    return 0; // (inf, a]
                if (a < x && x < b)
                    return (double)(x - a) / (double)(b - a);  // (a, b)
            }

            if (c is null || (b <= x && x <= c))
                return 1; // [b, inf) or [b, c]

            if (d is null || x < d)
            {
                // Descent (b->c if triangle, c->d if trapezoid)
                (double? cc, double? dd) = !(d is null) ? (c, d) : (b, c);
                return (double)(x - d) / (double)(c - d);  // (b, c) or (c, d)
            }

            return 0; // [c, inf) or [d, inf)
        }

    }
}
