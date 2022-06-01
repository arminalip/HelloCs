using System;
using System.Collections.Generic;

namespace ListofMovies
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

            Batman1.Genres = new List<Genres>();
            Batman1.Genres.Add(Genres.Action);
            Batman1.Genres.Add(Genres.Drama);
            Batman1.Genres.Add(Genres.Thriller);

            var Batman2 = new Movies<float, int>();
            Batman2.MovieName = "The Dark Night";
            Batman2.Director = "Christopher Nolan";
            Batman2.Rate = 9.0f;
            Batman2.ReleaseDate = 2008;

            Batman2.Genres = new List<Genres>();
            Batman2.Genres.Add(Genres.Action);
            Batman2.Genres.Add(Genres.Drama);
            Batman2.Genres.Add(Genres.Thriller);


            var Batman3 = new Movies<float, int>();
            Batman3.MovieName = "The Dark Knight Rises";
            Batman3.Director = "Christopher Nolan";
            Batman3.Rate = 8.4f;
            Batman3.ReleaseDate = 2012;

            Batman3.Genres = new List<Genres>();
            Batman3.Genres.Add(Genres.Action);
            Batman3.Genres.Add(Genres.Drama);
            Batman3.Genres.Add(Genres.Thriller);

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

            Show(firstlist);
            Show(secondlist);
        }

        public static void Show<T, V>(List<Movies<T, V>> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine("Movies name : " + item.MovieName);
                Console.WriteLine("Movie rate : " + item.Rate);
                Console.WriteLine("Release date : " + item.ReleaseDate);
                Console.WriteLine("Director : " + item.Director);
                if (!(item.Genres is null))
                {
                    if (item.Genres.Count > 0)
                    {
                        Console.Write("Genres : ");
                        foreach (var genre in item.Genres)
                        {
                            Console.Write(genre + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("--------------");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("--------------");
                    Console.WriteLine();
                }
            }
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

        private List<Genres> genres;

        public List<Genres> Genres
        {
            get { return genres; }
            set { genres = value; }
        }
    }

    enum Genres
    {
        Action,
        Adventure,
        Animation,
        Biography,
        Comedy,
        Crime,
        Documentary,
        Drama,
        Family,
        Fantasy,
        History,
        Horror,
        Musical,
        Mystery,
        Romance,
        SciFi,
        Sport,
        Thriller,
        War,
        Western
    }
}
