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

		//public static List<Movie> GetAll(){
		//	return Movies;
		//}
		public static List<Movie> GetAll() => Movies;

		public static Movie? GetById(int id) => Movies.FirstOrDefault(m => m.Id == id);
        public static void SeedData()
		{
			Movies.Add(new Movie()
			{
				Id = ++nextId,
				Title = "Title1",
				Director = "Author1",
				Style = "Thriller",
				ShortDescription = "Info...",
				Sessions = new List<Session>() {
					new Session()
					{
						Id=1,
						DateSession = new DateTime(2024,08,24),
						TimeSession = new TimeOnly(10,30)
					},
                    new Session()
                    {
                        Id=2,
                        DateSession = new DateTime(2024,08,25),
                        TimeSession = new TimeOnly(13,30)
                    },
                }
			}); ;
			Movies.Add(new Movie()
			{
				Id = ++nextId,
				Title = "Title2",
				Director = "Author2",
				Style = "Thriller",
				ShortDescription = "Info...",
				Sessions = new List<Session>() {
				new Session()
				{
					Id = 1,
					DateSession = new DateTime(2024, 08, 24),
					TimeSession = new TimeOnly(10, 30)
				},
				new Session()
				{
					Id = 2,
					DateSession = new DateTime(2024, 08, 25),
					TimeSession = new TimeOnly(13, 30)
				},
			} }
			);
		}




	}
}
