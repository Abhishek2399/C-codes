using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class EmployeeTest
    {

        static void Main()
        {
            /*
            // normal constructor syntax 
            Employee abhi = new Employee();

            // incase we need object with varying elements 
            // employee has 4 properties and the combinations woudl be 4! hence we would need 4! constructors
            // but it can be easily done by object intitalizers as follows
            // Syntax Class_name obj_name = new Class_name{}
            //eg:
            Employee rahul = new Employee { EmpName = "Rahul"}; // evry other element will be null/0 based on data type
            Employee shubham = new Employee { EmpName = "Shubham", EmpNo = 21, EmpSurname = "Singh"}; // evry other element will be null/0 based on data type
            Employee sarvesh = new Employee { EmpName = "Sarvesh", EmpSalary = 21000}; // evry other element will be null/0 based on data type

            */
            // not to use constructor use object intializer instead 

            // Inheritance 
            Manager abhi = new Manager { EmpName = "Abhishek", EmpNo = 121, EmpSurname = "Bhovar", DA = 12000, HRA = 34567 };
            Console.WriteLine(abhi.Display());

            Sales rohan = new Sales { EmpName = "Rohan", EmpNo = 127, EmpSurname = "Taute", LunchAllowance = 55, TravelAllowance = 1500 };
            Console.WriteLine(rohan.Display());

            Console.WriteLine($"{abhi.EmpName} {abhi.SalaryCalc()}"); // we can't implement the abstract method from parent class but the implementation of it in the child class
            Console.WriteLine($"{rohan.EmpName} {rohan.SalaryCalc()}");

        }

    }
}
