using Praticas.Builders;
using Praticas.Enums;

namespace Praticas.ConcreteBuilders
{
    public sealed class CinepolisBuilder : MovieBuilder
    {
        public override void SetGenre(GenreTypeEnum genreType)
        {
            movie.Genre = genreType;
        }

        public override void SetMovie()
        {
            movie.Id = Guid.NewGuid();
            movie.Title = "Movie Created by Cinepolis";
            movie.Year = new Random().Next(2000, DateTime.Now.Year);
        }
    }
}
