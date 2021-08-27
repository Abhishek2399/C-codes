using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection; 

namespace Reflections
{
    class Customer
    {
        public string name = "Abhi"; // Field1

        public static int num;
        public int cid { get; set; } // Property

        public Customer() // Constr
        {
            cid = 12;
        }

        public int Square( int num) // Method 
        {
            return num * num;
        }

        public void MulParam(int n, int m) // Method 
        {
            n = n + 100;
            m = m + 100;
            Console.WriteLine($"Value of p1 {n} Value of p2 {m}");
        }

        public void NoParam()
        {
            Console.WriteLine("No Parameters ");
        }


    }

    class Program
    {
        private static int num = 10;
        static int ChangeVariableValue(string varName)
        {
            Type mirror = typeof(Program);
            object obj = Activator.CreateInstance(mirror);
            FieldInfo toChange = mirror.GetField(varName, BindingFlags.NonPublic | BindingFlags.Static);
            object newVal = 90;
            toChange.SetValue(obj, newVal);
            return (int)toChange.GetValue(obj) ;
        }

        static void Main(string[] args)
        {
            // Using Reflection we can collect information of the ASsembly During Runtime 
            // We can collect every type of Information using Reflection 
            // MetaData -> information about information 

            // We are using class Customer to store some information and we information of the class storing information, for this we use reflection 

            Console.WriteLine("================== <Class info> ====================");
            Type mirror = typeof(Customer); // store meta data of type in 'Type' obj 
            Customer abhi = new Customer();
            Console.WriteLine(mirror.Name);            
            Console.WriteLine(mirror.IsClass); // checking if it is class
            Console.WriteLine(mirror.IsAbstract); // checking if class is Abstract
            Console.WriteLine(mirror.BaseType); // checking base/parent class


            // Getting Info about Constr.
            Console.WriteLine("================== <Constructor info> ====================");
            ConstructorInfo[] constrs = mirror.GetConstructors();
            foreach(var cons in constrs)
            {
                Console.WriteLine($"Name : {cons.Name}");
                Console.WriteLine($"IsPublic : {cons.IsPublic}");
                Console.WriteLine($"IsStatic : {cons.IsPublic}");
            }

            // Getting methods 
            Console.WriteLine("================== <Method info> ====================");
            MethodInfo[] methods = mirror.GetMethods();
            foreach(var method in methods)
            {
                Console.WriteLine(method.Name);
            }
            
            Console.WriteLine("================== <Parameter info> ====================");
            foreach (var method in methods)
            {
                Console.WriteLine($"Method : {method.Name}");
                ParameterInfo[] parameters = method.GetParameters();
                foreach(var param in parameters){
                    Console.WriteLine($"Name : {param.Name} [{param.ParameterType}]");
                }
                Console.WriteLine("-----------------------");
            }


            // Getting Field Information
            Console.WriteLine("================== <Field info> ====================");
            FieldInfo[] fields = mirror.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach(var field in fields)
            {
                Console.WriteLine($"Name : {field.Name} [{field.FieldType}]");
            }

            // static creation 
            Customer cust = new Customer();

            // object creation using Reflection aka Dynamic Binding
            object obj = Activator.CreateInstance(mirror); // used to create instance at runtime 
            MethodInfo toCall = mirror.GetMethod("Square"); // if name is not proper we will get runtime error while invoking function 

            object[] para = { 3 }; // object bcoz we dont know the param type, array bcoz we dont know number of params
            int ans = (int)toCall.Invoke(obj, para); // invoking or calling the parameter
            Console.WriteLine(ans);

            object[] prr = { 10, 20 }; // function with multiple params 
            toCall = mirror.GetMethod("MulParam");
            toCall.Invoke(obj, prr);

            prr = null;
            toCall = mirror.GetMethod("NoParam");
            toCall.Invoke(obj, prr);

            // Propertyinfo 

            PropertyInfo pi = mirror.GetProperty("cid"); // getting property

            FieldInfo pi2 = mirror.GetField("num"); // getting field 

            object val = 90;
            pi.SetValue(abhi, val);
            pi2.SetValue(abhi, val);
            
            Console.WriteLine(abhi.cid);
            Console.WriteLine(Customer.num);


            Assembly assm = Assembly.LoadFrom(@"D:\capgemini\training\technical\C#\ReflnByUbed\Reflections\AssemblyDemo\bin\Debug\AssemblyDemo.dll");
            Type[] classes = assm.GetTypes();
            Console.WriteLine("---------------------------------------");
            foreach (var clss in classes)
            {
                Console.WriteLine($"Name : {clss.Name}");
                Console.WriteLine($"Is Class : {clss.IsClass}");
                Console.WriteLine($"Is Interface : {clss.IsInterface}");
                MemberInfo[] mems = clss.GetMembers();
                foreach(var mem in mems)
                {
                    Console.WriteLine($"Member Name : {mem.Name} [{mem.GetType().ToString()}]");
                }
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine(num);
            ChangeVariableValue("num");
            Console.WriteLine(num);
        }
    }
}
