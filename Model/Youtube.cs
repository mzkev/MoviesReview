using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesReviewApp.Model
{
    public class SearchResult
    {
        public string kind { get; set; }
        public string nextPageToken { get; set; }
        public string prevPageToken { get; set; }
        public PageInfo pageInfo { get; set; }
        public Collection<YoutubeVideo> items { get; set; }
    }
    public class PageInfo
    {
        public int totalResults { get; set; }
        public int resultsPerPage { get; set; }

    }
    public class YoutubeVideo
    {
        public string id { get; set; }
        public Snippet snippet { get; set; }
    }
    public class Snippet
    {
        public string title { get; set; }
        public string description { get; set; }
        public Thumbnails thumbnails { get; set; }
        public Video resourceId { get; set; }
    }
    public class Thumbnails
    {
        public High high { get; set; }
    }
    public class Video
    {
        public string kind { get; set; }
        public string videoId { get; set; }
        public string videoURL
        {
            get
            {
                return "https://www.youtube.com/embed/" + videoId;
            }
        }
    }

   
    public class High
    {
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    


}
