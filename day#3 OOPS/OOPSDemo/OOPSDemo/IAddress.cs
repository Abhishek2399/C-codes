using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Adding Interface :- Project --> Add Item --> Interface
namespace OOPSDemo
{
    // no implementation just definition and everything abstract 
    interface IAddress : ICommunication // Name of interface should always start with 'I'
    {
        string showAddress(); // by default "public" in interface
        string City { get; set; } // by default "public" in interface
        string State { get; set; } // by default "public" in interface
        string Pincode { get; set; } // by default "public" in interface

    }

    interface ICommunication // Interface implementing interface
    {
        string Email { get; set; }
        long Mobile { get; set; }

    }

    public class Customer : ICommunication// implementing the Interface ':'
    {

        public string Email { get; set; } // we need to implement the Elements in the ICommunication
        public long Mobile { get; set; } // we need to implement the Elements in the ICommunication



        public int CusId { get; set; }
        public string CusName { get; set; }
        public string City { get; set ; }
        public string State { get; set ; }
        public string Pincode { get; set; }

        public string showAddress()
        {
            return null;
        }
    }
}
