namespace MVCTutorial.Entities
{
    public class MovieGenre
    {
        public Movie movie {  get; set; }
        public Genre genre { get; set; }
        public int MovieId { get; set; }
        public int GenreId { get; set; }

        public MovieGenre(Movie movie, Genre genre)
        {
            this.movie = movie;
            this.genre = genre;
            this.MovieId = movie.Id;
            this.GenreId = genre.Id;
        }
    }
}
