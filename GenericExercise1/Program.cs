using System;
using System.Collections.Generic;

namespace GenericExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstlist = new List<Movies<double, DateTime>>();
            var secondlist = new List<Movies<float, int>>();


            var Batman1 = new Movies<float, int>();
            Batman1.MovieName = "Batman Begins";
            Batman1.Director = "Christopher Nolan";
            Batman1.Rate = 8.3f;
            Batman1.ReleaseDate = 2005;

            var Batman2 = new Movies<float, int>();
            Batman2.MovieName = "The Dark Night";
            Batman2.Director = "Christopher Nolan";
            Batman2.Rate = 9.0f;
            Batman2.ReleaseDate = 2008;

            var Batman3 = new Movies<float, int>();
            Batman3.MovieName = "The Dark Knight Rises";
            Batman3.Director = "Christopher Nolan";
            Batman3.Rate = 8.4f;
            Batman3.ReleaseDate = 2012;


            var lordoftheRings1 = new Movies<double, DateTime>();
            lordoftheRings1.MovieName = "Lord of the Rings: The Fellowship of the Ring";
            lordoftheRings1.Director = "Peter Jackson";
            lordoftheRings1.Rate = 8.8;
            lordoftheRings1.ReleaseDate = new DateTime(2001, 12, 19);

            var lordoftheRings2 = new Movies<double, DateTime>();
            lordoftheRings2.MovieName = "Lord of the Rings: The Two Towers";
            lordoftheRings2.Director = "Peter Jackson";
            lordoftheRings2.Rate = 8.7;
            lordoftheRings2.ReleaseDate = new DateTime(2002, 12, 18);

            var lordoftheRings3 = new Movies<double, DateTime>();
            lordoftheRings3.MovieName = "Lord of the Rings: The Return of the King";
            lordoftheRings3.Director = "Peter Jackson";
            lordoftheRings3.Rate = 8.9;
            lordoftheRings3.ReleaseDate = new DateTime(2003, 12, 17);

            firstlist.Add(lordoftheRings1);
            firstlist.Add(lordoftheRings2);
            firstlist.Add(lordoftheRings3);

            secondlist.Add(Batman1);
            secondlist.Add(Batman2);
            secondlist.Add(Batman3);


            //Movies<double, DateTime> Batman1 = new Movies<double, DateTime>();
            //Batman1.MovieName = "Batman Begins";
            //Batman1.Director = "Christopher Nolan";
            //Batman1.Rate = 8.3;
            //Batman1.ReleaseDate = new DateTime(2005, 06, 15);

            //Movies<double, DateTime> Batman2 = new Movies<double, DateTime>();
            //Batman2.MovieName = "The Dark Night";
            //Batman2.Director = "Christopher Nolan";
            //Batman2.Rate = 9.0;
            //Batman2.ReleaseDate = new DateTime(2008, 06, 18);

            //Movies<double, DateTime> Batman3 = new Movies<double, DateTime>();
            //Batman3.MovieName = "The Dark Knight Rises";
            //Batman3.Director = "Christopher Nolan";
            //Batman3.Rate = 8.4;
            //Batman3.ReleaseDate = new DateTime(2012, 06, 20);
        }
    }

    class Movies<T, U>
    {
        private string movieName;

        public string MovieName
        {
            get { return movieName; }
            set { movieName = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private U releaseDate;

        public U ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        private T rate;

        public T Rate
        {
            get { return rate; }
            set { rate = value; }
        }
    }
}
