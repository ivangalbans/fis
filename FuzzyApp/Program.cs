using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Antlr4.Runtime;
using Antlr4.Runtime.Tree;

using Fuzzy.Function;
using Fuzzy.Parsing;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FuzzyApp
{
    class Program
    {
        static Dictionary<string, Type> _functions;

        static void Main(string[] args)
        {

            string argData = "tips.json"; // args[0];
            string argRules = "tips.fuz"; // args[1];
            double argStepSize = 0.1; // args[2]

            // Load from files
            var rules = new AntlrFileStream(argRules);
            dynamic data = JsonConvert.DeserializeObject<dynamic>(new StreamReader(argData).ReadToEnd());

            // Parse rules file

            var lexer = new FuzzyLexer(rules);

            var errors = new List<string>();
            lexer.RemoveErrorListeners();
            lexer.AddErrorListener(new ErrorListener(errors));

            var tokens = new CommonTokenStream(lexer);
            var parser = new FuzzyParser(tokens);

            parser.RemoveErrorListeners();
            parser.AddErrorListener(new ParserErrorListener(errors));

            IParseTree tree = parser.compileUnit();

            if (errors.Any())
            {
                Console.WriteLine();
                foreach (var item in errors)
                    Console.WriteLine(item);
                Environment.ExitCode = 1;
                return;
            }

            // Retieve dictionaries from data JSON file
            var values = data["variables"];

            Dictionary<string, FunctionBase> funcs = new Dictionary<string, FunctionBase>();
            foreach (JProperty f in data["functions"])
                funcs.Add(f.Name, GetFunction(f.Values().First(), f.Values().Skip(1)));


            Console.WriteLine(1e-6);

            // Evaluate rules expressions
            var evaluator = new Evaluator(values, funcs);
            dynamic result = evaluator.Visit(tree);

            (string model, string defuzzy, IEnumerable<dynamic> output) = (result.Item1, result.Item2, result.Item3);

            model = model.ToLower();

            if(model == "mamdani")
            {

            }

            //foreach (var item in output)
            //{
            //    Console.WriteLine(item.GetType());
            //    Console.WriteLine(item.Item1);
            //    Console.WriteLine(item.Item2);
            //    Console.WriteLine(item.Item3);
            //    Console.WriteLine();
            //}

            



        }

        private static FunctionBase GetFunction(JToken name, IEnumerable<JToken> parameters)
        {
            string fname = name.ToString();
            List<string> p = new List<string>();
            foreach (var item in parameters)
                p.Add(item.ToString());

            if(fname == "Trapezoid")
            {
                while (p.Count() < 4) p.Add("");
                double? a = null; if (p[0] != "") a = double.Parse(p[0]);
                double? b = null; if (p[1] != "") b = double.Parse(p[1]);
                double? c = null; if (p[2] != "") c = double.Parse(p[2]);
                double? d = null; if (p[3] != "") d = double.Parse(p[3]);
                return new Trapezoid(a, b, c, d);
            }
            if(fname == "Triangle")
            {
                double a = double.Parse(p[0]);
                double b = double.Parse(p[1]);
                double c = double.Parse(p[2]);
                return new Triangle(a, b, c);
            }
            if(fname == "Sigmoid")
            {
                double k = double.Parse(p[0]);
                double x0 = double.Parse(p[1]);
                return new Sigmoid(k, x0);
            }
            if(fname == "Gaussian")
            {
                double b = double.Parse(p[0]);
                double c = double.Parse(p[1]);
                return new Gaussian(b, c);
            }

            throw new NotSupportedException($"The functions {fname} not exists");
        }
    }
}
