using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLanguage
{
    // Student 
    // name , id, add, totalmks, percent -> private elements and c# properties 
    // submitAsign, playSports -> methods 

    class Student2
    {
        static float TotalMks = 120;

        public string Name {get; set;}
        public int ID {get; set;}
        public int Mks { get; set; }

        // public -> access granted to everyone
        // void -> return nothing
        public void SubmitAssign() 
        {
            Console.WriteLine("Assignment Submitted");
        }

        public int GetMks()
        {
            return Mks;
        }

        public float GetPercent()
        {
            float percent = (Mks/TotalMks)*100;
            return percent;
        }

        // ToString() -> object ka info 

        
        public override string ToString()
        {
            string info = string.Format($"Name:{Name}\nId:{ID}\nMks:{Mks}\nPercentage:{GetPercent()}");
            return info;
        }
        
    }

    class ClassObjsDemo
    {
        static void Main()
        {
            Student2 alkama; // declaration 
            alkama = new Student2();

            alkama.Name = "Alkama Shaheen";
            alkama.ID = 219;
            alkama.Mks = 90;

            //--------------------------------

            Console.WriteLine(alkama.GetMks());
            Console.WriteLine(alkama.GetPercent());

            Console.WriteLine(alkama);

        }
    }
}
