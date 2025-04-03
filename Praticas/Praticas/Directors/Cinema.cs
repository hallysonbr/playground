using Praticas.Builders;
using Praticas.Enums;
using Praticas.Models;

namespace Praticas.Directors
{
    public class Cinema
    {
        private readonly MovieBuilder _movieBuilder;

        public Cinema(MovieBuilder movieBuilder)
        {
            _movieBuilder = movieBuilder;
        }

        //Constructor
        public void InitMovie()
        {
            _movieBuilder.CreateMovie();
            _movieBuilder.SetMovie();

            var enumValues = Enum.GetValues(typeof(GenreTypeEnum));
            var typeOption = new Random().Next(enumValues.Length);

            _movieBuilder.SetGenre((GenreTypeEnum)typeOption);
        }

        public Movie GetMovie()
        {
            return _movieBuilder.GetMovie();
        }
    }
}
