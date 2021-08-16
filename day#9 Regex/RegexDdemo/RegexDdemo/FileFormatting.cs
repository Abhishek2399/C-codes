using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexDdemo
{
    
    class FileFormatting
    {
        public static bool IsFormatCorrect(string toValidate)
        {
            string validatePattern = "^[A-Z]";
            return Regex.IsMatch(toValidate, validatePattern);
        }

        public static bool WriteToFile(string fileName, List<string> newLines)
        {
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var line in newLines)
                {
                    sw.WriteLine(line);
                }
            }
                return true;
        }

        // line by line method of replacement 
        public static bool ReplaceFileWords(string fileName, string searchWord, string newWord) 
        {
            int lineNo = 0;
            string line;
            string newLine;
            List<string> newLines = new List<string>();
            using(StreamReader sr = new StreamReader(fileName))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    lineNo++;
                        Console.WriteLine($"{lineNo}.]{line}");
                        newLines.Add(Regex.Replace(line, searchWord, newWord));
                        Console.WriteLine($"{lineNo * -1}.]{newLines[lineNo - 1]}");
                        Console.WriteLine("\n");
                }
            }
            WriteToFile(fileName, newLines);

            return true;
        }

        
        
        // one shot method 
        public static bool ReplaceFileWords2(string fileName, string searchWord, string newWord)
        {
            string newContent;
            using (StreamReader sr = new StreamReader(fileName))
            {
                string wholeData = sr.ReadToEnd();
                newContent = Regex.Replace(wholeData, searchWord, newWord);
            }
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                sw.Write(newContent);
            }
            return true;
        }



        static void Main()
        {
            try
            {
                using (StreamReader sr = new StreamReader("abc.txt")) // opening the input file 
                {
                    using (StreamWriter sw = new StreamWriter("emp.txt")) // opening the output file
                    {
                        string line;
                        string toReplace = @"\s+";
                        string replaceBy = ",";
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (IsFormatCorrect(line))
                            {
                                string updatedLine = Regex.Replace(line, toReplace, replaceBy);
                                sw.WriteLine(updatedLine);
                            }
                        }
                    }
                }    
                ReplaceFileWords("news.txt", "Central", "Wednesday");
                ReplaceFileWords2("news.txt", "Western", "Central");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Created File ");
        }
    }
}
