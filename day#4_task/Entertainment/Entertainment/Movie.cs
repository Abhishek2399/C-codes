using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertainment
{
    public class Movie
    {
        
        // -----------------------------------
        // Auto-Implemented Properties
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public int Description { get; set; }

        public string MovieInfo()
        {
            return $"ID: {Id}\nName: {Name}\nYear: {Year}\nRating: {Rating}\nDescription: {Description}";
        }

    }
}
