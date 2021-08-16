using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    //Extension methods used to extend functionalites of existing classes
    // Rule 1.] The extension method should always be in the static class

    static class ExtensionDemo
    {
        // Rule 2.] The extension method should always be static
        public static int MyWordCount(this string str)// Rule 3.] The first parameter of extension method should be "this" indicating current object along with the type of obj and its ref. here is a string type object hence "this string" and var to ref it is "str" hence " this string str "
        {
            int count = str.Split(' ').Count(); // "split" will split the object in an array which is calling it in terms of the character given to it here it is space ' ' i.e. "my name is abhi" => Split => ["my", "name", "is", "abhi"]
            return count;
        }
        
        public static string OddEven(this int num) // as we want to work with integer type object hence "this int"
        {
            if (num % 2 == 0) return "Even";
            else return "Odd";
        }

        // trying to achieve the runtime polymorphism 
        public static string OddEven(this string str) 
        {
            if (str.Length % 2 == 0) return "Even Length";
            else return "Odd Length";
        }

        /* Failed Logic  
        // extension to get a contact number in format "123-456-789" and return it formated as 123456789
        public static string FormatContact(this string contactNo)
        {
            string[] splittedData = contactNo.Split('-');
            string validContact = ""; // created in one corner of the memory 
            for( int i=0; i< splittedData.Length; i++)
            { 
                validContact.Concat(splittedData[i]); // updated in another as this is ref type variable 
            }
            return validContact;
        }
        we cnt update the value if everytime the value is stored in new location 
        hence we have the StringBuilder class 
        */

        // extension to get a contact number in format "123-456-789" and return it formated as 123456789
        public static string FormatContact(this string contactNo)
        {
            StringBuilder sb = new StringBuilder(); // this object is updateable as it wont change the mem location 
            for (int i = 0; i < contactNo.Length; i++)
            {
                if (Char.IsDigit(contactNo[i])) // using IsDigit from char class to check wether the passed character is a string or not
                {
                    sb.Append(contactNo[i]);
                }
            }
            return sb.ToString();// as object is a string builder object we need to convert it to string-obj
        }

        public static float PenDiscount(this Pen p, float discRate ) // associating this extension to the pen class using "this Pen" hence this extension will work with pen objs 
        {
            float discount;
            discount = p.Rate * (discRate / 100); // dont know is the calculations are right 
            return discount;
        }
        

}
}
