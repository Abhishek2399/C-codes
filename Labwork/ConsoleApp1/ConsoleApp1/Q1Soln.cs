using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Q1Employee;

namespace LabWork
{
    class Q1Soln
    {
        static void Main(string[] args)
        {
            // creating the employee object of class Employee from the Q1Employee namespace from Q1Employee .dll
            
            /*
             * Employee emp = new Employee();


            Console.WriteLine("Enter ID of the Employee : "); // Printing on the console 
            emp.EmployeeId = Convert.ToInt32(Console.ReadLine()); // taking input with the help of Readline and converting the string type data to int type with the help of Convert.ToInt32

            Console.WriteLine("Enter the Name of the Employee : ");
            emp.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter the Address : ");
            emp.Address = Console.ReadLine();

            Console.WriteLine("Enter the City : ");
            emp.City = Console.ReadLine();

            Console.WriteLine("Enter the Department : ");
            emp.Department = Console.ReadLine();

            Console.WriteLine("Enter the Salary : ");
            emp.Salary= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(emp); // printing out the employee details 
            // priting info is done my over riding the ToString method related to the Employee class
            */

            // Creating an array of 10 emps
            int totalEmp = 3; 
            Employee[] employees = new Employee[totalEmp];

            for(int i=0; i<totalEmp; i++)
            {
                employees[i] = new Employee(); // initialising every employee object int the Employee array 
                //  getting data from the user for every object 
                Console.WriteLine("Enter ID of the Employee : "); 
                employees[i].EmployeeId = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Enter the Name of the Employee : ");
                employees[i].EmployeeName = Console.ReadLine();

                Console.WriteLine("Enter the Address : ");
                employees[i].Address = Console.ReadLine();

                Console.WriteLine("Enter the City : ");
                employees[i].City = Console.ReadLine();

                Console.WriteLine("Enter the Department : ");
                employees[i].Department = Console.ReadLine();

                Console.WriteLine("Enter the Salary : ");
                employees[i].Salary = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine(employees[1]);
            Console.WriteLine("-----------------------------");
            foreach(Employee employee in employees)
            {
                Console.WriteLine(employee);
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
            }

        }
    }
}
