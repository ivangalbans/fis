using Fuzzy.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuzzy.Model
{
    public static class ModelMethod
    {
        /// <summary>
        /// Mamdani model
        /// </summary>
        /// <param name="rulesOutput">List of tuples (w, outputVar, linguisticVal) representing the output of each rule's evaluation</param>
        /// <param name="defuzzy"> Defuzzification function</param>
        /// <param name="function">Dictionary which associates a linguistic value with its corresponding membership function</param>
        /// <param name="step">Distance between values to discretize function's domains</param>
        /// <returns>Dictionary that associates each output variable name with its calculated numeric value</returns>
        public static Dictionary<string, double> Mamdani(List<(double w, string outputVar, string linguisticVal)> rulesOutput,
            Func<FunctionBase, double, double> defuzzy, Dictionary<string, FunctionBase> function, double step=0.1)
        {
            rulesOutput.Sort((a, b) => a.outputVar.CompareTo(b.outputVar));
            var result = new Dictionary<string, double>();

            // group rules_output by the output variables
            foreach (var item in rulesOutput.GroupBy(a => a.outputVar)) 
            {
                // # List of tuples (trunc, function) which corresponds to variable 'var_name'
                var aggrFunc = item.Select(x => (x.w, function[x.linguisticVal]));
                var compose = new Compose(aggrFunc.ToList());

                // Defuzzify and store result corresponding to variable 'var_name'
                result.Add(item.Key, defuzzy(compose, step));
            }

            return result;
        }

        /// <summary>
        /// Sugeno model with weighted average
        /// </summary>
        /// <param name="rulesOutput">List of tuples (w, outputVar, z) representing the output of each rule's evaluation</param>
        /// <returns>Dictionary that associates each output variable name with its calculated numeric value</returns>
        public static Dictionary<string, double> Sugeno(List<(double w, string outputVar, double z)> rulesOutput)
        {
            var num = new Dictionary<string, double>();
            var den = new Dictionary<string, double>();

            foreach ((var w, var variable, var z) in rulesOutput)
            {
                num.TryGetValue(variable, out double lastNum);
                den.TryGetValue(variable, out double lastDen);

                if (!num.ContainsKey(variable)) num.Add(variable, lastNum);
                if (!den.ContainsKey(variable)) den.Add(variable, lastDen);

                num[variable] = lastNum + w * z;
                den[variable] = lastDen + w;
            }
            return Divide(num, den);
        }

        /// <summary>
        /// Tsukamoto model
        /// </summary>
        /// <param name="rulesOutput">List of tuples (w, outputVar, linguisticVal) representing the output of each rule's evaluation</param>
        /// <param name="function">Dictionary which associates a linguistic value with its corresponding membership function</param>
        /// <param name="step">Distance between values to discretize function's domains</param>
        /// <returns>Dictionary that associates each output variable name with its calculated numeric value</returns>
        public static Dictionary<string, double> Tsukamoto(List<(double w, string outputVar, string linguisticVal)> rulesOutput,
            Dictionary<string, FunctionBase> function, double step = 0.1)
        {
            var num = new Dictionary<string, double>();
            var den = new Dictionary<string, double>();

            foreach ((var w, var variable, var lingVal) in rulesOutput)
            {
                var func = function[lingVal];
                var points = func.Points(step);

                // Choose the one whose image is closer to 'w'
                // 'z' is the value of function's domain with image approximately 'w'
                var z = points.Aggregate((p1, p2) => (Math.Abs(p1.y - w) < Math.Abs(p2.y - w)) ? p1 : p2).x;

                num.TryGetValue(variable, out double lastNum);
                den.TryGetValue(variable, out double lastDen);

                if (!num.ContainsKey(variable)) num.Add(variable, lastNum);
                if (!den.ContainsKey(variable)) den.Add(variable, lastDen);

                num[variable] = lastNum + w * z;
                den[variable] = lastDen + w;
            }

            return Divide(num, den);
        }

        /// <summary>
        /// Divide values corresponding to the same key in two dictionaries
        /// </summary>
        /// <param name="num">Dividend dictionary</param>
        /// <param name="den">Divider dictionary</param>
        /// <returns>New dictionary with the same keys as the parameters and the divisions results as values</returns>
        private static Dictionary<string, double> Divide(Dictionary<string, double> num, Dictionary<string, double> den)
        {
            var dic = new Dictionary<string, double>();
            foreach (var variable in num.Keys)
            {
                if (!dic.ContainsKey(variable))
                    dic.Add(variable, num[variable] / den[variable]);
                dic[variable] = num[variable] / den[variable];
            }
            return dic;
        }
    }
}
