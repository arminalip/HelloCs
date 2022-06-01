using System;

namespace MoviesAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MoviesAssignment.Movie InceptionInstance = new MoviesAssignment.Movie();
            MoviesAssignment.Movie WildTalesInstance = new MoviesAssignment.Movie();

            InceptionInstance.MovieName = "Inception";
            InceptionInstance.Rate = 8.8;
            InceptionInstance.ReleaseDate = new DateTime(2010, 7, 16);

            InceptionInstance.Languages = new Language[3];
            InceptionInstance.Languages[0] = Language.English;
            InceptionInstance.Languages[1] = Language.French;
            InceptionInstance.Languages[2] = Language.Japanese;

            InceptionInstance.Countries = new Country[2];
            InceptionInstance.Countries[0] = Country.UnitedStatesofAmerica;
            InceptionInstance.Countries[1] = Country.UnitedKingdom;

            InceptionInstance.Genres = new Genres[3];
            InceptionInstance.Genres[0] = Genres.Action;
            InceptionInstance.Genres[1] = Genres.Adventure;
            InceptionInstance.Genres[2] = Genres.SciFi;


            WildTalesInstance.MovieName = "Wild Tales";
            WildTalesInstance.Rate = 8.1;
            WildTalesInstance.ReleaseDate = new DateTime(2014, 8, 21);

            WildTalesInstance.Languages = new Language[1];
            WildTalesInstance.Languages[0] = Language.Spanish;

            WildTalesInstance.Countries = new Country[2];
            WildTalesInstance.Countries[0] = Country.Argentina;
            WildTalesInstance.Countries[1] = Country.Spain;

            WildTalesInstance.Genres = new Genres[3];
            WildTalesInstance.Genres[0] = Genres.Comedy;
            WildTalesInstance.Genres[1] = Genres.Drama;
            WildTalesInstance.Genres[2] = Genres.Thriller;

            InceptionInstance.DisplayMovieInformation();
            WildTalesInstance.DisplayMovieInformation();
        }
    }
}
