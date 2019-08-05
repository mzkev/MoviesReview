using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using MoviesReviewApp.Model;
using Newtonsoft.Json;

namespace MoviesReviewApp.Pages
{
    public class IndexModel : PageModel
    {
        string api_key;
        string youtube_key;
        string youtube_playlistId;
        private readonly IConfiguration _configuration;
        public IndexModel(IConfiguration configuration)
        {
            _configuration = configuration;
            api_key = _configuration["Api_Key"];
            youtube_key = _configuration["Youtube_Key"];
            youtube_playlistId = _configuration["Youtube_Playlist"];
        }
        
        HttpClient httpClient = new HttpClient();
       
        public async Task OnGet()
        {
            await PopularMovies();
            await TrendingMovies();
            await UpcomingMovies();
            await TvShowsPopular();
            await TvShowsTopR();
            await ShowAiring();
            await GetYoutubeVideos();
            
        }
        public PopularMovie Index { get; set; }
        public PopularMovie Trend { get; set; }
        public PopularMovie Upcome { get; set; }
        public TvShowOnAir TvShow { get; set; }
        public TvShowOnAir TopRated { get; set; }
        public TvShowOnAir  showOnAir { get; set; }
        public SearchResult youtube { get; set; }


        
        public async Task PopularMovies()
        {
            var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/movie/popular?api_key={api_key}&language=en-US");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                Index = JsonConvert.DeserializeObject<PopularMovie>(apiResponse);
                
            }
        }
        public async Task TrendingMovies()
        {
            var res = await httpClient.GetAsync($"https://api.themoviedb.org/3/trending/movie/day?api_key={api_key}");
            string apiRes = await res.Content.ReadAsStringAsync();
            if (res.IsSuccessStatusCode)
            {
                Trend = JsonConvert.DeserializeObject<PopularMovie>(apiRes);
            }
            
        }
        public async Task UpcomingMovies()
        {

            var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/movie/upcoming?api_key={api_key}");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                Upcome = JsonConvert.DeserializeObject<PopularMovie>(apiResponse);
              
            }

        }

        public async Task TvShowsPopular()
        {
            var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/tv/popular?api_key={api_key}");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TvShow = JsonConvert.DeserializeObject<TvShowOnAir>(apiResponse);
            }

        }

        public async Task TvShowsTopR()
        {
            var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/tv/top_rated?api_key={api_key}");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                TopRated = JsonConvert.DeserializeObject<TvShowOnAir>(apiResponse);
            }

        }

        public async Task ShowAiring()
        {
            var response = await httpClient.GetAsync($"https://api.themoviedb.org/3/tv/on_the_air?api_key={api_key}");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                showOnAir = JsonConvert.DeserializeObject<TvShowOnAir>(apiResponse);
            }
        }

        public async Task GetYoutubeVideos()
        {
            var response = await httpClient.GetAsync($"https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=10&playlistId={youtube_playlistId}&key={youtube_key}");
            string apiResponse = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                youtube = JsonConvert.DeserializeObject<SearchResult>(apiResponse);
                
            }
        }


    }
}
