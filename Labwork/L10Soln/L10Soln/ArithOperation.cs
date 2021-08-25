using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L10Soln
{
    public class ArithOperation
    {
        public delegate int ArthOp(int a, int b);

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            return a / b;
        }

        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

    }


    class ArthDelTest
    {
        static List<string> operations = new List<string>()
            { "[1].Addition", "[2].Subtraction", "[3].Multiplication", "[4].Division", "[5].Max Number", "[-1].Exit"};

        public static void ShowOperations()
        {
            foreach(var op in operations)
            {
                Console.WriteLine(op);
            }    
        }

        static void Main()
        {
            ArithOperation arth = new ArithOperation();
            List<ArithOperation.ArthOp> arthDel = new List<ArithOperation.ArthOp>(){ arth.Add, arth.Sub, arth.Mul, arth.Divide, arth.Max};
            int toDo = 0, num1 = 0, num2 = 0;
            do
            {
                ShowOperations();
                Console.WriteLine("Enter you choice ");
                toDo = Convert.ToInt32(Console.ReadLine());
                if (toDo > 0 && toDo < operations.Count) {
                    Console.WriteLine($"Operation Selected -> {operations[toDo - 1]}");

                    Console.WriteLine("Enter the first number :");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the first number :");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(arthDel[toDo - 1](num1, num2)); 
                }
            } while (toDo != -1);

        }

    }

}
