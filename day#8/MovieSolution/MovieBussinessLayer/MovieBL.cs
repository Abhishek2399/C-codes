using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieDataAccessLAyer;
using MovieEntityLayer;

namespace MovieBussinessLayer
{
    public class MovieBL
    {
        public List<Movie> GetMoviesBL()
        {
            MovieDAL mvDAL = new MovieDAL();
            List<Movie> movies = mvDAL.GetMovies();
            return movies;
        }

        public Movie FindMovieBL(int ID)
        {
            MovieDAL mvDAL = new MovieDAL();
            if (ID > 0)
            {
                if (mvDAL[ID] != null)
                    return mvDAL[ID];
                else
                    throw new Exception("Movie Not Present ");
            }
            throw new Exception("Invalid ID\n");
        }
        
        public Movie FindMovieBL2(int ID)
        {
            MovieDAL mvDAL = new MovieDAL();
            if (ID > 0)
            {
                if (mvDAL[ID] != null)
                    return mvDAL.FindMovie(ID) ;
                else
                    throw new Exception("Movie Not Present ");
            }
            throw new Exception("ID should be positive \n");
        }


        public static bool IsMovieValid(Movie toValidate)
        {
            StringBuilder sb = new StringBuilder();
            if (toValidate.Name is null)
                sb.Append(Environment.NewLine + "Name should not be blank ");
            if (toValidate.Rating < 1 || toValidate.Rating > 10)
                sb.Append(Environment.NewLine + "Rating not in range ");
            if (toValidate.Year > 2021)
                sb.Append(Environment.NewLine + "Year exceeded current Year ");
            if (toValidate.ID < 0)
                sb.Append(Environment.NewLine + "Id should not be negative ");            
            else
                return true;
            throw new Exception(sb.ToString());
        }

        public bool AddMovieBL(Movie movieToAdd)
        {
            // id positive
            // name should not be blank
            // year not > 2021
            // rating 1-10
            bool isAdded=false;
            MovieDAL movieDAL = new MovieDAL();
            try
            {
                if (IsMovieValid(movieToAdd))
                {
                    movieDAL.AddMovieDAL(movieToAdd);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return isAdded;
        }


    }

}
