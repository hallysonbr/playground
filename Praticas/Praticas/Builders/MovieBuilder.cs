using Praticas.Enums;
using Praticas.Models;

namespace Praticas.Builders
{
    public abstract class MovieBuilder
    {
        protected Movie movie;

        public void CreateMovie() => movie = new Movie();

        public Movie GetMovie() => movie;

        public abstract void SetMovie();

        public abstract void SetGenre(GenreTypeEnum genreType);
    }
}
