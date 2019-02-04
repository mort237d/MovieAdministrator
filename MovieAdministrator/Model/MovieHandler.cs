using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using MovieAdministrator.Annotations;

namespace MovieAdministrator.Model
{
    class MovieHandler : INotifyPropertyChanged
    {
        private List<string> _sortingList;
        private ObservableCollection<Movie> _movies;
        private ObservableCollection<Movie> _listOffMovies = new ObservableCollection<Movie>();
        private Movie _selectedMovie, _selectedMovieFromList;
        private string _selectedSorting;

        public MovieHandler()
        {
            SortingList = new List<string>(){"Ratings", "A-Z", "Z-A", "Genre"};
            Movies = new ObservableCollection<Movie>()
            {
                new Movie("Mænd og Høns", "maend_og_hoens_plakat.jpg", "5.png", "Komedie", ""),
                new Movie("Adams Æbler", "adams_aebler.jpg", "4.png", "Komedie", ""),
                new Movie("Gamle mænd i nye biler", "poster.png", "3.png", "Vold", "")
            };
        }

        public List<string> SortingList
        {
            get { return _sortingList; }
            set { _sortingList = value; }
        }

        public ObservableCollection<Movie> Movies
        {
            get { return _movies; }
            set { _movies = value; }
        }

        public ObservableCollection<Movie> ListOffMovies
        {
            get { return _listOffMovies; }
            set { _listOffMovies = value; }
        }

        public Movie SelectedMovie
        {
            get { return _selectedMovie; }
            set
            {
                _selectedMovie = value;
                OnPropertyChanged();
            }
        }

        public Movie SelectedMovieFromList
        {
            get { return _selectedMovieFromList; }
            set
            {
                _selectedMovieFromList = value; 
                OnPropertyChanged();
            }
        }

        public string SelectedSorting
        {
            get { return _selectedSorting; }
            set
            {
                _selectedSorting = value;
                OnPropertyChanged();

                Sort(_selectedSorting);
            }
        }

        public void AddMovieToList()
        {
            if (!ListOffMovies.Contains(SelectedMovie))
            {
                ListOffMovies.Add(SelectedMovie);
            }
        }
        public void RemoveMoviefromList()
        {
            ListOffMovies.Remove(SelectedMovieFromList);
        }

        public void Sort(string sortType)
        {
            List<Movie> temp = null;
            switch (sortType)
            {
                case "A-Z":
                    temp = Movies.OrderBy(o => o.Title).ToList();
                    break;
                case "Z-A":
                    temp = Movies.OrderByDescending(o => o.Title).ToList();
                    break;
                case "Genre":
                    temp = Movies.OrderBy(o => o.Genre).ToList();
                    break;
                case "Ratings":
                    temp = Movies.OrderByDescending(o => o.Rating).ToList();
                    break;
            }
            

            Movies.Clear();
            foreach (var movie in temp)
            {
                Movies.Add(movie);
            }
        }

        #region INotify

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
