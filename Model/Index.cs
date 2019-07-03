using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesReviewApp.Model
{
    public class Index
    {
        public int id { get; set; }
        [Display(Name = "Rating")]
        public double vote_average { get; set; }
        public string title { get; set; }
        [Display(Name = "Total Votes")]
        public int vote_count { get; set; }
        public byte[] poster_path { get; set; }
        public string overview { get; set; }
        [Display(Name ="Release Date")]
        public DateTime release_date { get; set; }
        [Display(Name = "Genre")]
        public string genre { get; set; }
    }
}
