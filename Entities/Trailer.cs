namespace MVCTutorial.Entities
{
    public class Trailer
    {
        public int MovieId { get; set; }
        public string TrailerUrl { get; set; }
        public string Name { get; set; }
        public Movie movie { get; set; }
    }
}
