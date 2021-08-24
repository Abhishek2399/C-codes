using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using L3Q1Participant;

namespace L3Soln
{
    class Program
    {
        static void Main(string[] args)
        {
            Participant abhi = new Participant() { EmpId = 19, Name = "Abhishek", CompanyName = "CG", FoundationMks = 71, DotNetMks = 90, WebBasicMks = 90 };
            Console.WriteLine(abhi);
        }
    }
}
