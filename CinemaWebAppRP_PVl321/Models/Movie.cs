namespace CinemaWebAppRP_PVl321.Models
{
	public class Movie
	{
        public int Id { get; set; }
        public string Title { get; set; } = "NoTitle";
        public string? Director { get; set; }
        public string? Style { get; set; }
        public string? ShortDescription { get; set; }
        public List<Session> Sessions { get; set; } = new List<Session>();

    }
    
}
