using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MoviesReviewApp.Model;
using Newtonsoft.Json;

namespace MoviesReviewApp.Pages
{
    public class IndexModel : PageModel
    {
       public IList<Index> Index { get; set; }
        HttpClient httpClient = new HttpClient();
        
        public async Task OnGet()
        {
            var response = await httpClient.GetAsync("https://api.themoviedb.org/3/movie/popular?api_key=929321ac36adb5b4c6cf9d99173ce6fb&language=en-US&page=1");
            string apiResponse = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine(apiResponse);
                Index = JsonConvert.DeserializeObject<IList<Index>>(apiResponse).ToList();

            }
        }
    }
}
