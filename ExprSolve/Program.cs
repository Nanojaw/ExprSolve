using System;
using System.Collections.Generic;
using System.Linq;

namespace ExprSolve
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var exprString = args[0];

            // Create dictionary of all unknown values and set them to null
            Dictionary<char, int?> unknowns = new();

            foreach (var c in exprString)
            {
                if (!unknowns.ContainsKey(c) && char.IsLetter(c)) unknowns.Add(c, null);
            }
            
            var expression = new Expression(exprString, unknowns);
        }
    }
}
