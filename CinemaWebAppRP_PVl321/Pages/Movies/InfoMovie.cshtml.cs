using CinemaWebAppRP_PVl321.Models;
using CinemaWebAppRP_PVl321.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebAppRP_PVl321.Pages.Movies
{
    public class InfoMovieModel : PageModel
    {
        public Movie? MovieInfo { get; set; }
        public void OnGet(int id)
        {
            MovieInfo=MovieSevice.GetById(id);
        }
    }
}
