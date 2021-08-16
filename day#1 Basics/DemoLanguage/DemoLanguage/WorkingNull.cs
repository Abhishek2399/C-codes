using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{

    class Student
    {
        string name;
        int age;
        int? id=null;
        Random rand_id = new Random();
        public Student()
        {
            this.id = rand_id.Next(100);
        }

        public int GetID()
        {
            if(this != null)
            {
                return (int)this.id;
            }
            return -1;
        }

        public int SetAge(int? id=null, int? age=null)
        {
            if (this.id.HasValue)
            {
                this.age = (int)age;
                return 1;
            }
            return -1;
        }


    }

    class WorkingNull
    {

        static void Main()
        {
            /*
            // there are some case types where need to store the null values where we dont have data 
            // applications which are connected to database, where database stores the null values 
            // in C# it is easy to give null values to reference variables 
            // eg:- string type or object type 
            string name = null;
            object o = null;

            // we can directly assign null to the value type data 
            //int salary = null; // uncommenting follwoing line will show the error
            // we can assing null to value type vars in following way 
            //1.
            int? age = null;
            float? mks = null;
            //2.
            Nullable<int> total = null;

            // we can check this null values 
            if (total.HasValue)
            {
                Console.WriteLine("Value Present");
            }
            else
            {
                Console.WriteLine("Value Not Present");
            }
            */
            Student abhi = new Student();
            Console.WriteLine(abhi.GetID());
            

        }

    }
}
