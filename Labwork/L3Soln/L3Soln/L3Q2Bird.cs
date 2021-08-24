using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L3Soln
{
    class Bird
    {
        public string Name;
        public double ?Maxheight;
        public Bird() //Default Constructor
        {
            this.Name = "Mountain Eagle";
            this.Maxheight = 500;
            //
            // TODO: Add constructor logic here
            //
        }
        public Bird(string birdname, double max_ht) //Overloaded Constructor
        {
            this.Name = birdname;
            this.Maxheight = max_ht;
        }
        public void fly()
        {
            Console.WriteLine($"{this.Name} is flying at altitude {this.Maxheight}");
        }
        public void fly(double AtHeight)
        {
            if (AtHeight <= this.Maxheight)
                Console.WriteLine(this.Name + " flying at " + AtHeight.ToString());
            else
                Console.WriteLine($"{this.Name} cannot fly at this height");
        }
    }
}
