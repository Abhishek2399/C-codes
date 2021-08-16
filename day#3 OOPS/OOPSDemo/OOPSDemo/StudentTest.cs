using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class StudentTest
    {
        static void Main()
        {
            Student abhi = new Student();
            abhi.Name = "abhi";
            abhi.RollNo = 12;
            abhi.Java = 79;
            abhi.Oracle= 55;
            abhi.SQL = 97;
            abhi.DotNet= 89;
            abhi.HTML = 55;


            Student xyz = new Student(name:"xyz", rollNo : 21, java : 55, oracle : 45.6f, sql : 55.89f, dotNet : 67.1f, html : 47);


            Console.WriteLine($"{abhi.Name} Total -> {abhi.GetTotalMarks()}");
            Console.WriteLine($"{xyz.Name} Grades -> {xyz.GetGrades()}");


            Console.WriteLine("-------------------------");
            Console.WriteLine(abhi.GetDetails());
            Console.WriteLine("-------------------------");
            Console.WriteLine(xyz.GetDetails());
            Console.WriteLine("-------------------------");




        }
    }
}
