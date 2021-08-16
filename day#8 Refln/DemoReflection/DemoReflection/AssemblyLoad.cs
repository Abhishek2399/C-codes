using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; // for assembly class
namespace DemoReflection
{
    class AssemblyLoad
    {
        static void Main()
        {
            try
            {
                // here we have dynamically got the methods of everytype in one project/soln
                string filename = @"D:\capgemini\training\technical\day#3\OOPSDemo\OOPSDemo\bin\Debug\OOPSDemo.exe";
                Assembly assembly = Assembly.LoadFrom(filename);
                Type[] types = assembly.GetTypes(); // getting all the classes present in the assembly object 
                foreach (var type in types)
                {
                    Console.WriteLine($"-------------------<{type.Name}>--------------------");
                    MemberInfo[] members = type.GetMembers();
                    foreach (var mi in members)
                    {
                        Console.WriteLine($"{mi.Name} ---------- {mi.MemberType}");
                    }
                    Console.WriteLine("------------------------------------------");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
