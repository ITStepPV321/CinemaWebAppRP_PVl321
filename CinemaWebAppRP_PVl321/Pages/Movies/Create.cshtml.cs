using CinemaWebAppRP_PVl321.Models;
using CinemaWebAppRP_PVl321.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebAppRP_PVl321.Pages.Movies
{
	[IgnoreAntiforgeryToken]
	public class CreateModel : PageModel
	{
		public string? Message { get; set; }

		[BindProperty]
        public Movie? NewMovie { get; set; }
        public void OnGet()
		{
		}

		//variant 4 with BindProperty - It's Good)
		public IActionResult OnPost()
		{

			Message = NewMovie.Title;
		    if (String.IsNullOrEmpty(NewMovie.Title) && String.IsNullOrEmpty(NewMovie.Director) && String.IsNullOrEmpty(NewMovie.ShortDescription))
				return Page();
			MovieSevice.Add(NewMovie);
			//return Page();
			return RedirectToPage("../Index");
		}

		//variant 3 - THE BEST
		//public IActionResult OnPost(Movie newMovie)
		//{

		//	Message = newMovie.Title;

		//	MovieSevice.Add(newMovie);
		//	//return Page();
		//	return RedirectToPage("../Index");
		//}

		//public IAction
		//variant 2
		//public IActionResult OnPost()
		//{
		// Movie newMovie = new Movie()
		//	{
		//		Title = Request.Form["Title"].ToString(),
		//		Director = Request.Form["Director"].ToString(),
		//		Style = Request.Form["Style"].ToString(),
		//		ShortDescription = Request.Form["ShortDescription"].ToString()
		//	};
		//	MovieSevice.Add(newMovie);
		//	//return Page();
		//	return RedirectToPage("../Index");
		//}

		//variant 1
		////public IActionResult OnPost(string Title, string Director, string Style, string ShortDescription ) {
		//    Message = Title;

		//    Movie newMovie = new Movie() { 
		//        Title = Title, 
		//        Director = Director,    
		//        Style = Style,
		//        ShortDescription = ShortDescription
		//             };
		//    MovieSevice.Add(newMovie);
		//    //return Page();
		//    return RedirectToPage("../Index");
		//}
	}
}
