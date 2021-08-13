using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Student
    {
        private string name, grades;
        private int rollNo;
        private float java, sql, oracle, dotNet, html, total_mks, total_avg;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = value; }
        }

        public float Java
        {
            get { return java; }
            set { java = value; }
        }

        public float SQL
        {
            get { return sql; }
            set { sql = value; }
        }

        public float Oracle
        {
            get { return oracle; }
            set { oracle = value; }
        }
        public float DotNet
        {
            get { return dotNet; }
            set { dotNet = value; }
        }

        public float HTML
        {
            get { return html; }
            set { html = value; }
        }

        public Student(string name, int rollNo, float java, float sql, float oracle, float dotNet, float html)
        {
            this.name = name;
            this.rollNo = rollNo;
            this.java = java;
            this.sql = sql;
            this.oracle = oracle;
            this.dotNet = dotNet;
            this.html = html;
        }

        public Student()
        {
            this.name = null;
            this.rollNo = 0;
            this.java = 0;
            this.sql = 0;
            this.oracle = 0;
            this.dotNet = 0;
            this.html = 0;
        }

        public float GetTotalMarks()
        {
            total_mks = java + sql + oracle + dotNet + html;
            return total_mks;
        }
        public float GetAvgMarks()
        {
            total_avg = GetTotalMarks() / 5;
            return total_avg;
        }

        public string GetGrades()
        {          
            if(GetAvgMarks() >= 75)
            {
                grades = "Frist Grade";
                return grades;
            }
            else if(GetAvgMarks() < 70 && GetAvgMarks() >= 60)
            {
                grades = "Second Grade";
                return grades;
            }
            else if (GetAvgMarks() < 60 && GetAvgMarks() >= 40)
            {
                grades = "Third Grade";
                return grades;
            }
            grades = "Fail";
            return grades;
        }

        public string GetDetails()
        {
            string details = string.Format($"Name : {name}\nRollNo : {rollNo}\n\nMarks:\nJava = {java}\nSQL = {sql}\nOracle = {oracle}\nDotNet = {dotNet}\nHTML = {html}\n\nTotal Marks = {GetTotalMarks()}\nTotal Avg = {GetAvgMarks()}\n\nGrade : {GetGrades()}");
            return details;
        }


    }
}


//making regions in the code  feature of visual studio 

#region
//<code block>
#endregion
