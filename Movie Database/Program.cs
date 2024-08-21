using Movie_Database;

bool dontStop = true;
List<Movie> movieTheatre = new List<Movie>()
{
    new Movie("Apocalypto", "Action/Adventure"),
    new Movie("Everything Everywhere All at Once", "Sci-Fi"), 
    new Movie("City of God", "Action/Adventure"),
    new Movie("Clerks II", "Comedy"),
    new Movie("Jackpot", "Comedy"),
    new Movie("Crazy Rich Asians", "Rom-Com"),
    new Movie("Definitely, Maybe", "Rom-Com"), 
    new Movie("Altered Carbon", "Sci-Fi"),
    new Movie("Dark", "Sci-Fi"),
    new Movie("Mr. & Mrs. Smith (BUT THE REBOOT)", "Action/Comedy"),
};

List<string> movieGenres = new List<string>()
{
    new string("Action/Adventure"),
    new string("Sci-Fi"),
    new string("Comedy"),
    new string("Rom-Com"),
    new string("Action/Comedy"),
};

Console.WriteLine("What category of movie would you like to see? Here are you options:   ");
foreach (string g in movieGenres)
{
    Console.WriteLine(g);
}
string userChoice = Console.ReadLine().Trim().ToLower();

while (dontStop)
{
    Console.Write("Comedy or adventure?   ");
    string clarification = Console.ReadLine().Trim().ToLower();
    if (userChoice.Contains("action"))
    {
        if (clarification.Contains("adventure"))
        {
            //Console.WriteLine(Movie[0]);
            Console.WriteLine(movieTheatre[2]);
            dontStop = !true;
        }
        else if (clarification.Contains("comedy"))
        {
            Console.WriteLine(movieTheatre[9]);
            dontStop = !true;
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose from comedy or adventure.");
            break;
        }
    }
}        


//----------------------------------------------------------------------------------------------------------------------
//                                                         CODE GRAVEYARD 

/*
List<Movie> sortedMovies = movieTheatre.OrderBy(m => m.Category).ToList();
   for (int s = 0; s < movieTheatre.Count(); s++) 
   {
       Console.WriteLine(movieTheatre[s]);
   }

Dictionary<string, string> newMovieTheatre = new Dictionary<string, string>();
newMovieTheatre.Add("Apocalypto", "Action/Adventure");
newMovieTheatre.Add("Everything Everywhere All at Once", "Sci-Fi");
newMovieTheatre.Add("City of God", "Action/Adventure");
newMovieTheatre.Add("Clerks II", "Comedy");
newMovieTheatre.Add("Jackpot", "Comedy");
newMovieTheatre.Add("Crazy Rich Asians", "Rom-Com");
newMovieTheatre.Add("Definitely, Maybe", "Rom-Com");
newMovieTheatre.Add("Altered Carbon", "Sci-Fi");
newMovieTheatre.Add("Dark", "Sci-Fi");
newMovieTheatre.Add("Mr. & Mrs. Smith (BUT THE REBOOT)", "Action/Comedy");
/*
foreach (KeyValuePair<string, string> kvp in newMovieTheatre)
{
    Console.WriteLine(kvp.Key);
}


foreach (KeyValuePair<string, string> kvp in newMovieTheatre)
{
    if (userChoice.Contains("sci"))
    {
        Console.WriteLine(kvp.Key[1]);
        Console.WriteLine(kvp.Key[7]);
        Console.WriteLine(kvp.Key[8]);
    }
    else if (userChoice.Contains("com"))
    {
        Console.WriteLine(kvp.Key[3]);
        Console.WriteLine(kvp.Key[4]);
    }
    else if (userChoice.Contains("rom"))
    {
        Console.WriteLine(kvp.Key[5]);
        Console.WriteLine(kvp.Key[6]);
    }
}
*/