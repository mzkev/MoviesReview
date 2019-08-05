using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesReviewApp.Model
{
    public class TvShowOnAir
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public Collection<TvshowResult> results { get; set; }
    }

    public class TvshowResult
    {
        public int id { get; set; }
        public Collection<int> genre_ids { get; set; }
        public string name { get; set; }
        public string popularity { get; set; }
        public double vote_average { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }
        public string fullImagePath
        {
            get
            {
                return "https://image.tmdb.org/t/p/w500" + poster_path;
            }
        }
    }
}
