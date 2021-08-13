using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // for the IEnumerable interface 

namespace Q1Employee
{
    public class Employee : IEnumerable
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            string info = string.Format($"Name : {EmployeeName}\nID : {EmployeeID}\nAddress : {Address}\nCity : {City}\nDepartment : {Department}\nSalary : {Salary}");// format in which we want to display the employee info 
            return info;
        }

        // Indexers for converting the object in such a way it can use indexing to get data 

        public string this[int pos] // must have a get/set direct of value not possible 
        {
            get
            {
                return this.ToString();
            }
        }

        
    }
}
