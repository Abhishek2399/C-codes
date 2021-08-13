using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDdemo
{
    class ReplaceTest
    {
        static void Main()
        {
            string input = "today is   Wednesday";
            string toReplace= @"\s+"; // \s spaces \s+ multiple spaces
            string replaceBy = "-";
            Regex regex = new Regex(toReplace);
            string replaced = regex.Replace(input, replaceBy);
            Console.WriteLine($"{input} =======> {replaced}");
        }
    }
}
