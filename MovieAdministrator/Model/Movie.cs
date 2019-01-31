namespace MovieAdministrator.Model
{
    class Movie
    {
        private string _title, _poster, _genre, _rating, _destination;

        public Movie(string title, string poster, string rating, string genre, string destination)
        {
            Title = title;
            Poster = "Posters/" + poster;
            Rating = "Ratings/" + rating;
            Genre = genre;
            Destination = destination;
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Poster
        {
            get { return _poster; }
            set { _poster = value; }
        }

        public string Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }
    }
}
