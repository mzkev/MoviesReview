using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace MoviesReviewApp.Model
{
    public class PopularMovie
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public Collection<Movieresult> results { get; set; }
    }
    public class Movieresult
    {
        public int id { get; set; }
        [Display(Name = "Rating")]
        public double vote_average { get; set; }
        public string title { get; set; }
        [Display(Name = "Total Votes")]
        public int vote_count { get; set; }
        public string poster_path { get; set; }
        public string imageFullpath
        {
            get
            {
                return "https://image.tmdb.org/t/p/w500" + poster_path;
            }
        }
        public string overview { get; set; }
        [Display(Name ="Release Date")]
        public string release_date { get; set; }
        [Display(Name = "Genre")]
        public Collection<int> genre_ids { get; set; }
    }

}
