using System.ComponentModel.DataAnnotations;

namespace CinemaWebAppRP_PVl321.Models
{
    public class Session
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateSession { get; set; }
      
        public TimeOnly TimeSession { get; set; }

    }
}
