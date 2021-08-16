using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDdemo
{
    class SplitTest
    {
        static void Main()
        {
            string input = "20 + 50 / 5 * 100";
            string pattern1 = @"\s+"; // we are using \s+ as we want to divide only for multiple spaces 
            var results = Regex.Split(input, pattern1);
            foreach(var result in results)
                Console.WriteLine(result);
        }
    }
}
