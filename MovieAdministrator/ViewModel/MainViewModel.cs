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

        public RelayCommand RemoveMovieCommand { get; set; }
        public RelayCommand AddMovieCommand { get; set; }

        public RelayCommand AddVisibibleCommand { get; set; }

        public MainViewModel()
        {
            AddMovieToListCommand = new RelayCommand(MovieHandler.AddMovieToList);
            RemoveMovieFromListCommand = new RelayCommand(MovieHandler.RemoveMoviefromList);

            RemoveMovieCommand = new RelayCommand(MovieHandler.RemoveMovie);

            AddVisibibleCommand = new RelayCommand(MovieHandler.AddVisible);
        }
    }
}
