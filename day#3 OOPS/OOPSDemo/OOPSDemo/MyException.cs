using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPSDemo
{
    class MyException : ApplicationException // user defined exception has to inherit from Applicaiton Exception class
    {
        // here the constructor will call the ApplicationException constr. which will in turn call the Exception class
        public MyException(string msg) : base(msg) {  // string msg passed to the MyException class will pass that str to the base constructor class
            WriteToFile(msg);
        }

        public static void WriteToFile(string msg)
        {
            string printline = string.Format($"Error Occured at {DateTime.Now} It was related to {msg}");
            StreamWriter sw = new StreamWriter("Error.txt", true); // will write the informattion in the file "Error.txt"
            sw.WriteLine(printline);
            sw.Close();
        }
    }
}
