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
    }
}
