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
        public static Dictionary<string, double> Mamdani(List<(object w, string outputVar, string linguisticVal)> rulesOutput,
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
    }
}
