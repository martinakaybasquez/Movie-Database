using Movie_Database;

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

while (true)
{
    Console.Write("Comedy or adventure?   ");
    string clarification = Console.ReadLine().Trim().ToLower(); 
    if (userChoice.Contains("action"))
    {
        if (clarification.Contains("adventure"))
        {
            foreach (Movie m in movieTheatre)
            {
                Console.WriteLine(movieTheatre[0]);
                Console.WriteLine(movieTheatre[2]);
            }
        }
        else if (clarification.Contains("comedy"))
        {
            foreach (Movie m in movieTheatre)
            {
                Console.WriteLine(movieTheatre[9]);
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please choose from comedy or adventure.");
            break;
        }
    }
}


