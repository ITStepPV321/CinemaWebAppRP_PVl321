using CinemaWebAppRP_PVl321.Models;
using CinemaWebAppRP_PVl321.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebAppRP_PVl321.Pages.Sessions
{
    public class CreateModel : PageModel
    {
        public  Movie? Movie { get; set; }
        public int? IdMovie { get; set; }
        public void OnGet(int id)
        {
            Movie=MovieSevice.GetById(id);
            IdMovie = Movie.Id;

        }

        public IActionResult OnPost(Session session, int idMovie)
        {
            MovieSevice.AddSessionToMovie(session, idMovie);

            return RedirectToPage("/Movies/InfoMovie",new{id= idMovie });
        }



    }
}
