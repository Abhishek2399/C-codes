using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3Q1Participant
{
    public class Participant
    {

        public static float totalMks = 300f;
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public float FoundationMks { get; set; }
        public float WebBasicMks { get; set; }
        public float DotNetMks { get; set; }

        public float ObtainedMarks()
        {
            float ans = FoundationMks + WebBasicMks + DotNetMks;
            return ans;
        }

        public float Percentage()
        {
            float percent = (ObtainedMarks() / totalMks)*100;
            return percent;
        }

        public override string ToString()
        {
            string info = $"Name : {Name}\nEmployee ID : {EmpID}\nCompany Name : {CompanyName}\nObtained Marks : {ObtainedMarks()}\nPercentage : {Percentage()}%";
            return info;
        }



    }
}
