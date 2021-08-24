using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3Q1Participant
{
    public class Participant
    {
        static int totalMks = 300;
        static string companyName;
        private double foundationMks;
        private double dotNetMks;
        private double webBasicMks;

        public int EmpId { get; set; }
        public string Name { get; set; }
        
        public double FoundationMks
        {
            get { return foundationMks; }
            set
            {
                if(value < 0 | value > 100){
                    foundationMks = 0;
                }
                else
                {
                    foundationMks = value;
                }
            }
        }

        public double DotNetMks
        {
            get { return dotNetMks; }
            set
            {
                if (value < 0 | value > 100)
                {
                    dotNetMks = 0;
                }
                else
                {
                    dotNetMks = value;
                }
            }
        }

        public double WebBasicMks
        {
            get { return webBasicMks; }
            set
            {
                if (value < 0 | value > 100)
                {
                    webBasicMks = 0;
                }
                else
                {
                    webBasicMks = value;
                }
            }
        }


        static Participant()
        {
            companyName = "Corporate University";
        }

        public Participant()
        {
            // Default Values 
            Name = null;
            EmpId = -1;
            FoundationMks = 0;
            WebBasicMks = 0;
            DotNetMks = 0;
        }

        public Participant(string name, int empId, double foundationMks, double webBasicMks, double dotNetMks)
        {
            Name = name;
            EmpId = empId;
            FoundationMks = foundationMks;
            WebBasicMks = webBasicMks;
            DotNetMks = dotNetMks;
        }

        public double ObtainedMks()
        {
            double ans = FoundationMks + WebBasicMks + DotNetMks;
            return ans;
        }

        public double Percentage()
        {
            return (ObtainedMks()/totalMks) * 100;
        }

        public override string ToString()
        {
            string info = $"----------\nName : {Name}\nEmpId : {EmpId}\nCompany Name : {companyName}\nObtained Marks : {ObtainedMks()}\nPercentage : {Percentage()}\n----------\n";
            string mks = $"############\nFoundation Mks : {FoundationMks}\nDotNet Marks : {dotNetMks}\nWebBasic Marks : {webBasicMks}\n############";
            return info+mks;
        }

    }
}
