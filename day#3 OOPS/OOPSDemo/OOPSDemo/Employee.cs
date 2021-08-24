using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    abstract class Employee
    {
        // Auto generated Property 
        // Syntax - <access_modifer> <return_type> <Property_name> {get; set;}
        // if we want the property to perform read only make set as private 
        // read only eg:  <access_modifer> <return_type> <Property_name> {get; private set;}
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string EmpSurname { get; set; }
        public abstract int SalaryCalc();

        public Employee()
        {

        }

        public string Display()
        {
            string display = $"Name : {EmpName} {EmpSurname} \n";
            return display;
        }

    }
}
