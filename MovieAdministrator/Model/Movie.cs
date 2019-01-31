using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAdministrator.Model
{
    class Movie
    {
        private string _title, _poster, _genre;
        private int _rating;

        public Movie(string title, string poster, int rating, string genre)
        {
            Title = title;
            Poster = poster;
            Rating = rating;
            Genre = genre;
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

        public int Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
    }
}
