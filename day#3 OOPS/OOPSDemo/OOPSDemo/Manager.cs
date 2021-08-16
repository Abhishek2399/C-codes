using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Manager : Employee // Manager -> derived Employee -> base
    {
        public int HRA { get; set; }
        public int DA { get; set; }

        public new string Display() // new states that this Display belongs to the DErived class

        {
            string online = $"{base.Display()}Employee No : {EmpNo} \nHRA : {HRA}\nDA : {DA}"; // EmpNo was inherited where as the base.Display will call the Display from base class

            return online;
            
        }

        public override int SalaryCalc() // override as SalaryCalc was abstarct in parent 
        {
            return EmpSalary + DA + HRA;
        }
    }
}
