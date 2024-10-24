namespace MVCTutorial.Entities
{
    public class MovieCast
    {
        public Movie movie {  get; set; }
        public Cast cast { get; set; }
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string Character {  get; set; }
        public MovieCast(Movie movie, Cast cast, string character)
        {
            this.movie = movie;
            this.cast = cast;
            MovieId = movie.Id;
            CastId = cast.Id;
            Character = character;
        }
    }
}
