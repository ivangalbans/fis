using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;

namespace Fuzzy.Parsing
{
    public class Evaluator : FuzzyBaseVisitor<dynamic>
    {
        dynamic tnorm;
        dynamic tconorm;

        dynamic values;
        dynamic funcs;

        public Evaluator(dynamic values, dynamic funcs)
        {
            this.values = values;
            this.funcs = funcs;
            tnorm = tconorm = null;
        }

        public override dynamic VisitFile([NotNull] FuzzyParser.FileContext context)
        {
            tnorm   = GetFunction(context.ID(1).GetText().ToLower());
            tconorm = GetFunction(context.ID(2).GetText().ToLower());

            string defuzzy = null;
            if (!(context.ID(3) is null))
                defuzzy = context.ID(3).GetText();

            return (context.ID(0).GetText(), defuzzy, from x in context.fuzzy_rule() select Visit(x));
        }

        public override dynamic VisitSRule([NotNull] FuzzyParser.SRuleContext context)
        {
            var w = Visit(context.logic_expr());
            var variable = context.ID().GetText();
            var z = Visit(context.arithmetic_expr());
            return (w, variable, z);
        }

        public override dynamic VisitMTRule([NotNull] FuzzyParser.MTRuleContext context)
        {
            var trunc = Visit(context.logic_expr());
            var variable = context.ID(0).GetText();
            var func = context.ID(1).GetText();
            return (trunc, variable, func);
        }

        public override dynamic VisitLVarValue([NotNull] FuzzyParser.LVarValueContext context)
        {
            var variable = context.ID(0).GetText();
            var func = context.ID(1).GetText();
            return funcs[func].Evaluate(double.Parse(values[variable].ToString()));
        }

        public override dynamic VisitLParens([NotNull] FuzzyParser.LParensContext context)
        {
            return Visit(context.logic_expr());
        }

        public override dynamic VisitLAnd([NotNull] FuzzyParser.LAndContext context)
        {
            return tnorm(Visit(context.logic_expr(0)), Visit(context.logic_expr(1)));
        }

        public override dynamic VisitLOr([NotNull] FuzzyParser.LOrContext context)
        {
            return tconorm(Visit(context.logic_expr(0)), Visit(context.logic_expr(1)));
        }

        public override dynamic VisitLNot([NotNull] FuzzyParser.LNotContext context)
        {
            return 1 - Visit(context.logic_expr());
        }

        public override dynamic VisitAVar([NotNull] FuzzyParser.AVarContext context)
        {
            return double.Parse(values[context.ID().GetText()]);
        }

        public override dynamic VisitANumber([NotNull] FuzzyParser.ANumberContext context)
        {
            return double.Parse(context.NUMBER().GetText());
        }

        public override dynamic VisitAParens([NotNull] FuzzyParser.AParensContext context)
        {
            return Visit(context.arithmetic_expr());
        }

        public override dynamic VisitAArithmetic([NotNull] FuzzyParser.AArithmeticContext context)
        {
            dynamic e1 = Visit(context.arithmetic_expr(0));
            dynamic e2 = Visit(context.arithmetic_expr(1));
            var op = context.op.Text;

            if (op == "**") return Math.Pow(e1, e2);
            if (op == "*")  return e1 * e2;
            if (op == "/")  return e1 / e2;
            if (op == "+")  return e1 + e2;
            if (op == "-")  return e1 - e2;
            throw new NotSupportedException();
        }

        public override dynamic VisitANeg([NotNull] FuzzyParser.ANegContext context)
        {
            return -Visit(context.arithmetic_expr());
        }


        private Func<double, double, double> GetFunction(string name)
        {
            if (name == "product")
                return (x, y) => x * y;
            if (name == "sum")
                return (x, y) => x + y;
            if (name == "max")
                return (x, y) => Math.Max(x, y);
            if (name == "min")
                return (x, y) => Math.Min(x, y);
            throw new NotSupportedException();
        }
    }
}
