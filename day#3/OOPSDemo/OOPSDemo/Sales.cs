using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Sales : Employee // inheriting employee
    {
        public int TravelAllowance { get; set; }
        public int LunchAllowance { get; set; }

        public override int SalaryCalc()
        {
            return EmpSalary + TravelAllowance + LunchAllowance;
        }

        public new string Display() // new states that this Display belongs to the DErived class

        {
            string online = $"{base.Display()}Employee No : {EmpNo} \nTravelAllowance : {TravelAllowance}\nLunchAllowance : {LunchAllowance}"; // EmpNo was inherited where as the base.Display will call the Display from base class
            return online;
        }

    }
}
