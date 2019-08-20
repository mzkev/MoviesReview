using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MoviesReviewApp.Model;
using Newtonsoft.Json;

namespace MoviesReviewApp.Pages
{
    public class GalleryModel : PageModel
    {
        HttpClient client = new HttpClient();
        string api_key;
        string youtube_key;
        string youtube_playlistId;
        private readonly IConfiguration _configuration;
        public GalleryModel(IConfiguration configuration)
        {
            _configuration = configuration;
            api_key = _configuration["Api_Key"];
            youtube_key = _configuration["Youtube_Key"];
        }
        public async Task OnGetAsync()
        {
            await GalleryGrid();
           await PlayMovie();
        }

        public PopularMovie popular { get; set; }
        public SearchResult youtube { get; set; }

        public Collection<Movieresult> movieArray;
        public List<YoutubeVideo> result = new List<YoutubeVideo>();

        
        string movieTitle;

        public async Task GalleryGrid()
        {
            var response = await client.GetAsync($"https://api.themoviedb.org/3/movie/popular?api_key={api_key}&language=en-US");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                popular = JsonConvert.DeserializeObject<PopularMovie>(apiResponse);
                movieArray = new Collection<Movieresult>(popular.results.ToList());
            }
        }
        public async Task PlayMovie()
        {
            foreach (var movie in movieArray)
            {
                movieTitle = movie.title.ToString();

                var response = await client.GetAsync($"https://www.googleapis.com/youtube/v3/search?part=snippet&maxResults=1&q={movieTitle}%20trailer&key={youtube_key}");
                string apiResponse = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    youtube = JsonConvert.DeserializeObject<SearchResult>(apiResponse);
                    
                }
                
                result.AddRange(youtube.items);
            }
           
        }
    }
}