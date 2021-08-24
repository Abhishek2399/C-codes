using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L3Q1Participant;

namespace L3Soln
{
    class PariticipantTest
    {
        static void Main(string[] args)
        {
            Participant abhi = new Participant() { EmpId = 19, Name = "Abhishek", FoundationMks = 71, DotNetMks = 105, WebBasicMks = 90 };
            Participant unkown = new Participant();

            Participant rahul = new Participant(name:"Rahul", foundationMks : 80, webBasicMks : 80, dotNetMks : 80, empId : 12);

            Console.WriteLine(abhi);
            Console.WriteLine(unkown);
            Console.WriteLine(rahul);

        }
    }
}
