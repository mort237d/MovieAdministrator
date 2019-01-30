using System.Collections.Generic;

namespace MovieAdministrator.Model
{
    class MovieHandler
    {
        private List<string> _sortingList;

        public MovieHandler()
        {
            SortingList = new List<string>(){"Ratings", "A-Z", "Z-A", "Genre"};
        }

        public List<string> SortingList
        {
            get { return _sortingList; }
            set { _sortingList = value; }
        }
    }
}
