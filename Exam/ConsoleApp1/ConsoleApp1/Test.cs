using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    
    class Test
    {
        static int num = 1;

        public int ChangeVar(string var)
        {
            this.GetType().GetProperty(var).SetValue(num, 10);
            return num;
        }

        static void Main()
        {
            Test t = new Test();

            FieldInfo[] mems = t.GetType().GetFields(BindingFlags.Static);
            foreach( var data in mems)
            {
                Console.WriteLine(data.Name);
            }
            
            
        }

    }

}
