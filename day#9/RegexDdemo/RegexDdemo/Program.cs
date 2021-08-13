using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip1 = "TodayisWednesday";
            string ip2 = "today is wednesday";
            string pattern = @"^[a-zA-Z0-9]*$";

            Console.WriteLine("ip1 is matched "+Regex.IsMatch(ip1, pattern));
            Console.WriteLine("ip2 is matched "+Regex.IsMatch(ip2, pattern));
            Console.WriteLine();

            string pattern2 = @"^[0-9]{3}[A-Z]{2}$";
            string ip3 = "45ET"; // this will be false for pattern2 as there should be 3 mumeric characters 
            Console.WriteLine("ip3 is matched "+Regex.IsMatch(ip3, pattern2));

            string pattern3 = @"^[0-9]{0,3}[A-Z]{2}$";
            string ip4 = "45ET"; // this will be true for pattern3 as there can be 0-3 numeric chars in the line 
            Console.WriteLine("ip4 is matched " + Regex.IsMatch(ip4, pattern3));
            Console.WriteLine();
            // mathching white space 
            string ip5 = "SuperMan"; // will give false as there is no space after Super
            string ip6 = "Super Man"; // will give treu as there is space after super 
            string pattern4 = @"^Super\s"; // start with "Super" and there should be a space after Super 
            Console.WriteLine("ip5 is matched " + Regex.IsMatch(ip5, pattern4));
            Console.WriteLine("ip6 is matched " + Regex.IsMatch(ip6, pattern4));
            Console.WriteLine();


            // matching any website pattern 
            // start with -> www
            // end with .com
            string webPattern = @"^[w]{3}[.][a-zA-Z]{3,20}[.](com|in|net)";
            // () -> used for string set and should have an logical operator if more than one strings
            string website1 = @"www.TimesOfIndia.net";
            string website2 = @"wwwTimesOfIndianet";
            string website3 = @"www.TimesOfIndia.org";
            Console.WriteLine("site1 is matched " + Regex.IsMatch(website1, webPattern));
            Console.WriteLine("site2 is matched " + Regex.IsMatch(website2, webPattern));
            Console.WriteLine("site3 is matched " + Regex.IsMatch(website3, webPattern));

            // using regex obj 
            Regex reg = new Regex(webPattern);
            Console.WriteLine($"Using reg-obj on site1 {reg.IsMatch(website1)}");





        }
    }
}
