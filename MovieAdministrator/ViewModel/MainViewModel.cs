using GalaSoft.MvvmLight.Command;
using MovieAdministrator.Model;

namespace MovieAdministrator.ViewModel
{
    class MainViewModel
    {
        private MovieHandler _movieHandler = new MovieHandler();

        public MovieHandler MovieHandler
        {
            get { return _movieHandler; }
            set { _movieHandler = value; }
        }

        public RelayCommand AddMovieToListCommand { get; set; }
        public RelayCommand RemoveMovieFromListCommand { get; set; }

        public RelayCommand Sort { get; set; }
        public RelayCommand ReverseSort { get; set; }

        public MainViewModel()
        {
            AddMovieToListCommand = new RelayCommand(MovieHandler.AddMovieToList);
            RemoveMovieFromListCommand = new RelayCommand(MovieHandler.RemoveMoviefromList);
        }
    }
}
