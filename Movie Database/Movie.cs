namespace Movie_Database;

internal class Movie
{
    // properties 
    public string Title { get; set; }
    public string Category { get; set; }
    
    // constructor 
    public Movie(string _title, string _category)
    {
        Title = _title;
        Category = _category;
    }
}