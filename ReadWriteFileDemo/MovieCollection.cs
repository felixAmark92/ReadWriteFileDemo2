namespace ReadWriteFileDemo;

public class MovieCollection
{
    private List<Movie> _movies;

    public List<Movie> Movies => _movies;

    public MovieCollection()
    {
        PopulateMovies();
    }

    private void PopulateMovies()
    {
        _movies = new List<Movie>()
        {
            new Movie()
            {
                Title = "Scream",
                Description = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, " +
                              "who targets the girl and her friends by using horror films as part of a deadly game.",
                Length = 1.85,
                Genres = new List<Genres>()
                {
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Event Horizon",
                Description = "A rescue crew investigates a spaceship that disappeared into a black hole and has now returned..." +
                              "with someone or something new on-board.",
                Length = 1.6,
                Genres = new List<Genres>()
                {
                    Genres.SciFi,
                    Genres.Horror,
                    Genres.Thriller
                }
            },
            new ()
            {
                Title = "Awakenings",
                Description = "The victims of an encephalitis epidemic many years ago have been catatonic " +
                              "ever since, but now a new drug offers the prospect of reviving them.",
                Length = 2.017,
                Genres = new List<Genres>()
                {
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "Constantine",
                Description = "Supernatural exorcist and demonologist John Constantine helps a policewoman " +
                              "prove her sister's death was not a suicide, but something more.",
                Length = 2.017,
                Genres = new List<Genres>()
                {
                    Genres.Action,
                    Genres.Fantasy,
                    Genres.Horror
                }
            },
            new ()
            {
                Title = "Don't Look Up",
                Description = "Two low-level astronomers must go on a giant media tour to warn humankind of an approaching comet that will destroy planet Earth.",
                Length = 2.3,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.SciFi,
                    Genres.Comedy
                }
            },
            new ()
            {
                Title = "Barbie",
                Description = "Ima barbie girl, in a babie world",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Comedy,
                    Genres.Fantasy,
                }
            },
            new ()
            {
                Title = "The Godfather",
                Description = "Maffia",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.Crime
                }
            },
            new ()
            {
                Title = "Oppenheimer",
                Description = "Oppenheimerstyle, bomb go boom!",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                    Genres.Thriller
                }
            },
            new ()
            {
                Title = "Interstellar",
                Description = "When Earth becomes uninhabitable in the future, a farmer and ex-NASA pilot, Joseph Cooper,",
                Length = 2.85,
                Genres = new List<Genres>()
                {
                    Genres.SciFi,
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "Fight Club",
                Description = "People fight",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Thriller,
                    Genres.Drama
                }
            },
            new ()
            {
                Title = "The Dark knight",
                Description = "Batman fight",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Action,
                    Genres.Crime
                }
            },
            new ()
            {
                Title = "Return of the king",
                Description = "Frodo dont fight",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Fantasy,
                    Genres.Action
                }
            },
            new ()
            {
                Title = "scary movie",
                Description = " derp",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Horror,
                    Genres.Comedy
                }
            },
            new ()
            {
                Title = "The Pianist",
                Description = " very sad",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Drama,
                }
            },

            new ()
            {
                Title = "Wall-e",
                Description = " animated pixar movie",
                Length = 2.0,
                Genres = new List<Genres>()
                {
                    Genres.Comedy,
                    Genres.SciFi
                }
            },

        };
    }
}