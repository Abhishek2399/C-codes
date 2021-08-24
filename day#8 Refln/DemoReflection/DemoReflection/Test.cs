using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection;

namespace DemoReflection
{
    class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }


    }

    class StudentImplementation
    {
        public string GetNAme(Student s)
        {
            return s.Name;
        }

        public int GetTotalMks(IList<Student> studs)
        {
            int ans = 0;
            foreach( var stud in studs)
            {
                ans += stud.Score;
            }
            return ans;
        }

        public double GetAvgMks(IList<Student> studs)
        {
            double ans = 0d;
            ans = GetTotalMks(studs) / studs.Count;
            return ans;
        }

    }

    class Test
    {
        static int num = 1;
        static void Main()
        {



        }
    }
}
