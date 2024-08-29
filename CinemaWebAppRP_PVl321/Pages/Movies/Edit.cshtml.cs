using CinemaWebAppRP_PVl321.Models;
using CinemaWebAppRP_PVl321.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebAppRP_PVl321.Pages.Movies
{
    [IgnoreAntiforgeryToken]
    public class EditModel : PageModel
    {
        public Movie? EditMovie { get; set; }
        public void OnGet(int id)
        {
            EditMovie = MovieSevice.GetById(id);

        }


		//"../Index"=> Pages/Index
		//"/Index"  =>Pages/Index
		//"./Index"  =>Pages/Movies/Index
		//"Index"  =>Pages/Movies/Index
		public IActionResult OnPost(Movie movie) {

            if (!ModelState.IsValid)
            {
                return RedirectToPage("Edit", new { movie.Id });
            }
			//if (String.IsNullOrEmpty(movie.Title) && String.IsNullOrEmpty(movie.Director))
			//	return RedirectToPage("Edit", new {movie.Id});
				//return RedirectToPage($"Edit/{movie.Id}");
				//return  RedirectToRoute($"./Edit/{movie.Id}");
				
			MovieSevice.Update(movie);
            //return RedirectToPage("../Index");
            return RedirectToPage("/Index");
        }
        
    }
}
