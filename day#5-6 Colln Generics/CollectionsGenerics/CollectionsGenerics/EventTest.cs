using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectionsGenerics
{
    class EventTest
    {
        static void Main()
        {
            Pen parkor = new Pen { Rate = 200, Color = "red" };
            // Handling of the event has to be immediately after the object has been created 
            parkor.RateChange += ShowMessage; // object subscribing to the event 
            // handling is just giving some instructions{method} of what has to be done when the event has raised 
            // if we want the same event to write the message to a text file we will multi cast the new file writing instructions
            parkor.RateChange += WriteToFile;

            Console.WriteLine(parkor);
            parkor.NewRate(250);
            Console.WriteLine(parkor);
            parkor.NewRate(1900);
            parkor.NewRate(1990);
            parkor.NewRate(10);

            // Not compulsory to handle all the events 
        }

        public static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void WriteToFile(string msg)
        {
            StreamWriter sw = new StreamWriter("Event.txt", true);// true is to append the data we are writing
            sw.WriteLine(msg);
            sw.Close();  // dont forget to close else the data wont be saved 
        }
    }
}
