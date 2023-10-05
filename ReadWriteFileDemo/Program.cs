using ReadWriteFileDemo;

var movieDb = new MovieCollection();

//Path.Combine används för att bygga sökvägar på ett korrekt sätt.
//I Environment kan man hitta alla standard-mappar i en windowsdator. Tex. AppData, Desktop, MyDocuments mm.
var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "NiklasNet23");
Directory.CreateDirectory(directory);
var path = Path.Combine(directory, "Demo.txt");

//File.Exists kan användas för att kontrollera ifall en fil finns på en given sökväg




if (!File.Exists(path))
{

    using StreamWriter sw = new StreamWriter(path);
    foreach (var movie in movieDb.Movies)
    {
        //WriteLine används för att skriva en ny rad.
        sw.WriteLine(movie);
    }
    sw.Close();
}


List<Movie> GetMoviesFromFile(string path)
{
    if (!File.Exists(path))
    {
        return new List<Movie>();
    }

    List<Movie> movieList = new List<Movie>();
    string? line = "";

    string title = "";
    string length = "";
    string description = "";
    string genres = "";

    using StreamReader sr = new StreamReader(path);


    while ((line = sr.ReadLine()) != null)
    {
        if (line.StartsWith("Title: "))
        {
            title = line.Substring(7);
        }
        else if (line.StartsWith("Length: "))
        {
            length = line.Substring(8);
        }
        else if (line.StartsWith("Description: "))
        {
            description = line.Substring(13);
        }
        else if (line.StartsWith("Genres: "))
        {
            genres = line.Substring(8);
        }
        else
        {
            Movie tempMovie = new Movie();
            tempMovie.Title = title;
            tempMovie.Description = description;

            string lengthText = length.Split(' ')[0];
            tempMovie.Length = double.Parse(lengthText);

            string[] genresText = genres.Split(',');
            List<Genres> genresList = new List<Genres>();
            foreach (var genre in genresText)
            {
                if (genre == "")
                {
                    break;
                }

                genresList.Add(Enum.Parse<Genres>(genre));
            }

            tempMovie.Genres = genresList;
            movieList.Add(tempMovie);
        }
    }

    return movieList;

}


Console.WriteLine("---------------------------------");
Console.WriteLine("---------------------------------");

var dict = new Dictionary<Genres, List<Movie>>()
    {
        { Genres.SciFi, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.SciFi)).ToList() },
        {Genres.Action, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Action)).ToList() },
          {Genres.Comedy, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Comedy)).ToList()} ,
         {Genres.Drama, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Drama)).ToList()},
          {Genres.Horror,movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Horror)).ToList()},
         {Genres.Thriller, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Thriller)).ToList()},
          {Genres.Fantasy, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Fantasy)).ToList()},
          {Genres.Crime, movieDb.Movies.Where(m => m.Genres.Any(g => g == Genres.Crime)).ToList()},
    };



foreach (var genreList in dict)
{
    using var streamWriter = new StreamWriter(genreList.Key.ToString() + ".Juice");

    foreach (var movie in genreList.Value)
    {
        streamWriter.Write(movie.ToString() + '\n');
    }

}



var movies = GetMoviesFromFile("Action.juice");


foreach (var item in movies)
{
    Console.WriteLine(item.Title);
}


//var SciFiMovies =

