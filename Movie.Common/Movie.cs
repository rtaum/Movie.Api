namespace Movie.Common
{
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; init; }

        public int Year { get; init; }

        public string Name { get; init; } = null!;
    }
}