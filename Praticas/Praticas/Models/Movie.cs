using Praticas.Enums;

namespace Praticas.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public GenreTypeEnum Genre { get; set; }

        public string ShowMovie() => $"You choose this movie: {Id} - {Title} - {Year} - {Genre}";
    }    
}
