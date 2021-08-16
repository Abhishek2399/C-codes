using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // where the IEnumerable class resides

namespace CollectionsGenerics
{
    // we need to access these elements in the Class by "for" and without using indexers and also without givig a private access
    class MyCalendar : IEnumerable
    {
        // used string and splitted it into arrays of strings
        string[] Days = "Sun, Mon, Tue, Wed, Thu, Fri, Sat".Split(','); // Creating an array of Days 
        string[] Months = "Jan, Feb, Mar, April, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec".Split(',');

        // whenever we want to create iterations of our own class this is the Process/Steps
        // as we implements the Interface IEnumerable we need to implmenet the method of return Type IEnumerator of name "GetEnumerator"

        public IEnumerator GetEnumerator() // GetEnumerator{called when foreach ran} => IEnumerator => Current and we get the current data 
        {
            for(int i=0; i<Days.Length; i++)
            {
                yield return Days[i]; // "yield" is taking this object and returning it to IEnumerator 
                // yield is only for GetEnumerator only 
                // here if i=0 yeild "sun" will be sent to the IEnumerator which will again pass it on to the Current-method
                // this will return to the IEnumerator 
            }
        }

        // We need to explicitly write the method to get the months
        // Explicit Iteration Method for each
        public IEnumerable GetMonths()// IEnumerable => GetEnumerator{Made at Runtime} => IEnumerator => Current and we get the data current one 
        {
            for(int i=0; i<Months.Length; i++)
            {
                yield return Months[i];
            }
        }
    }
}
