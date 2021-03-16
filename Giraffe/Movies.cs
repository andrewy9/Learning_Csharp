using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Movies
    {
        public string title;
        public string director;
        private string rating;

        public Movies(string aTitle, string aDirector, string aRating) //Constructor
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating  //Property - special method allowng defining of getter and setter
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
