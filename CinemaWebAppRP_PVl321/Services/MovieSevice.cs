using CinemaWebAppRP_PVl321.Models;

namespace CinemaWebAppRP_PVl321.Services
{
	public static class MovieSevice
	{
		public static List<Movie> Movies { get; set; }
		static int nextId = 0;
		static MovieSevice()
		{
			Movies = new List<Movie>();
			SeedData();
		}

		public static void SeedData()
		{
			Movies.Add(new Movie()
			{
				Id = ++nextId,
				Title = "Title1",
				Director = "Author1",
				Style = "Thriller",
				ShortDescription = "Info..."
			});
			Movies.Add(new Movie()
			{
				Id = ++nextId,
				Title = "Title2",
				Director = "Author2",
				Style = "Thriller",
				ShortDescription = "Info..."
			}
			);
		}




	}
}
