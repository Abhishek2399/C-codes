using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace DemoReflection
{
    class DynamicMethodCall
    {
        static void Main()
        {
            try
            {
                string ofType = "DemoReflection.MyMath";
                Assembly assembly = Assembly.GetExecutingAssembly();
                Type type = assembly.GetType(ofType);
                object objMath = assembly.CreateInstance(ofType);

                PropertyInfo[] properties = type.GetProperties();
                properties[0].SetValue(objMath, 71); //
                properties[1].SetValue(objMath, 91); //

                MethodInfo method = type.GetMethod("Add");// gettting the very specific method we want to use 
                int result = (int)method.Invoke(objMath, null);// first param is the obj the method belongs to and the 2nd is the param of the method we are invoking here it is null as Add wont accept any values 
                Console.WriteLine($"{method.Name}: {result}");

                MethodInfo method2 = type.GetMethod("Mul");
                result = (int)method2.Invoke(objMath, new object[] { 4, 2 }); // params accepted by the method are sent as array based on number of params a method cn accept 
                Console.WriteLine($"{method2.Name} : {result}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
