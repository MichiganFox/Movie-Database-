using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MOVIE_DATABASE
{
    public class Movies
    {
        //Properties
        public string movie { get; set; }
        public string type { get; set; }

        //Constructor
        //The class should also provide a constructor that accepts a title and category as parameters and uses the values passed in to initialize the member variables.
        public Movies(string _name, string _type)
        {
            movie = _name;
            type = _type;

        }

        //Methods
        //methods
        public string GetDetails()
        {
            return $"Your {movie} Category:{type}";
        }
        public string GetType()
        {
            return $"Here is your movie category: {type}";
        }

        public string GetName()
        {
            return $"Here is your movie category: {movie}";
        }
        public static bool GetContinue()
        {
            bool result = true;

            while (true)
            {
                Console.WriteLine("Would you like to run again? y/n");
                string choice = Console.ReadLine().Trim().ToLower();
                if (choice == "y")
                {
                    result = true;
                    break;
                }
                else if (choice == "n")
                {
                    result = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            return result;
        }
      

    }
}

     
