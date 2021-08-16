using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDdemo
{
    class MatchTest
    {
        static void Main()
        {
            string ip = "The Sun sets in the west during Summer";
            string pattern = @"\bS\S*"; // '\b' starting of the word \S* for getting the whole world 
            MatchCollection matches = Regex.Matches(ip, pattern);
            foreach(var match in matches)
            {
                Console.WriteLine( match);
            }
            Console.WriteLine("-------------------------");

            string pattern2 = @"\bv\S*e\b"; 
            // '\b' : represents the boundary of the word 
            // '\bv' start with 'v'
            // 'e\b' end with 'e'
            // \S*' any number of chars in between

            string input = "Worldwide studies are under the way to understand if a combination of two different vaccines can outperform two doses of the same vaccine. Experts caution, however, that mixing should not be Randomly done but should be based on Understanding multiple issues.";

            matches = Regex.Matches(input, pattern2);

            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
            Console.WriteLine("-----------------------------");

            string names = "Tom,Amit,Ajay,Raj,Viraat,Dhoni,abhishek";
            string pattern3 = @"\b[Aa]\w+";
            // '\w' is a word 
            // '\w+' is for multiple words
            matches = Regex.Matches(names, pattern3);

            foreach(var match in matches)
            {
                Console.WriteLine(match);
            }


        }
    }
}
