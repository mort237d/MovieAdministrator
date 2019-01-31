using System.Collections.Generic;

namespace MovieAdministrator.Model
{
    class MovieHandler
    {
        private List<string> _sortingList;
        private List<Movie> _movies;

        public MovieHandler()
        {
            SortingList = new List<string>(){"Ratings", "A-Z", "Z-A", "Genre"};
            Movies = new List<Movie>(){new Movie("Mænd og Høns", "Posters/adams_aebler.jpg", 5), new Movie("Adams Æbler", "Posters/maend_og_hoens_plakat.jpg", 4) };
        }

        public List<string> SortingList
        {
            get { return _sortingList; }
            set { _sortingList = value; }
        }

        public List<Movie> Movies
        {
            get { return _movies; }
            set { _movies = value; }
        }
    }
}
