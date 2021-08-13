using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L3Q1Participant;

namespace ConsoleApp1
{
    class Q3_1Soln
    {
        static void Main() {
            Participant abhi = new Participant();
            abhi.EmpID = 1;
            abhi.Name = "Abhi";
            abhi.CompanyName = "Capgemini";
            abhi.DotNetMks = 92.81f;
            abhi.FoundationMks= 87.9f;
            abhi.WebBasicMks = 91.5f;

            Console.WriteLine(abhi);

        }
    }
}
