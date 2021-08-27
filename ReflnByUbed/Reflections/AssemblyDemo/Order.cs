using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyDemo
{
    public class Order
    {
        private int num;
        public int oid;
        public Order()
        {
            oid = 100;
        }

        public Order(int id)
        {
            oid = id;
        }

        public void Message()
        {
            Console.WriteLine("Hey this is abhi");
        }
    }

    public interface IDisp
    {

    }

}
