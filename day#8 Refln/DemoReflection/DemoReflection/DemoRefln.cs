using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPSDemo;
using System.Reflection;
using System.IO;

// visual studio contains appn that give information 
// solnExplorer -> References -> system -> object EXplorer[

namespace DemoReflection
{
    // Dotnet class is defined as type 
    class DemoRefln
    {
        static void Main(string[] args)
        {
            Pen parkor = new Pen { Color = "Blue", Rate = 21 };

            FileInfo fi = new FileInfo(@"D:\capgemini\training\technical\C#\day#8 Refln\DemoReflection\DemoReflection\DemoRefln.txt");

            Console.WriteLine($"File Exists -> {fi.Exists}");

            Console.WriteLine("-----------<Reflection of Pen Instance>-----------------");
            Console.WriteLine($"Name : {parkor.GetType().Name}"); // just the name of the class
            Console.WriteLine($"FullName : {parkor.GetType().FullName}"); // name of class along with fullname 
            Console.WriteLine($"Assembly : {parkor.GetType().Assembly.ToString()}"); // Assembly info{ProjectName, Version, PublicKey, Culture} Culture : Currency Symbol, date time format are diff in diff countries this is nothing but culture 
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("-----------<Reflection of Pen Without Instance>-----------------");
            // Type can be used to store reflection of any class 
            Type penType = typeof(Pen); // typeof gives the meta data of the class passed 
            Console.WriteLine($"Name : {penType.Name}"); // just the name of the class
            Console.WriteLine($"FullName : {penType.FullName}"); // name of class along with fullname 
            Console.WriteLine($"Assembly : {penType.Assembly.ToString()}"); // Assembly info{ProjectName, Version, PublicKey, Culture} Culture : Currency Symbol, date time format are diff in diff countries this is nothing but culture 
            Console.WriteLine("--------------------------------------------------------");

            
            // getmembers 
            Console.WriteLine();
            Console.WriteLine("-----------<Members of Type pen>-----------------");
            MemberInfo[] members = penType.GetMembers(); // gets the information of members from the type object specified
            foreach(var mi in members)
            {
                Console.WriteLine($"{mi.Name} ------------ {mi.MemberType}");// mi.Name name of the member, mi.MemberType type of the curret member 
            }
            Console.WriteLine("-------------------------------------------------");

        }
    }
}
