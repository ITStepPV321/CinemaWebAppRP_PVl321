using CinemaWebAppRP_PVl321.Models;
using CinemaWebAppRP_PVl321.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebAppRP_PVl321.Pages
{
	public class IndexModel : PageModel
	{
		public string? Message { get; set; }
		public List<Movie> Movies { get; set; }=new ();
        public IndexModel()
        {
            Movies = MovieSevice.Movies;
        }

        //GET-request
        public void OnGet()
		{
			Message = "Using property from page model";
		}
	}
}
