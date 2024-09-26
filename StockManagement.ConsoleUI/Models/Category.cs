namespace StockManagement.ConsoleUI.Models;

public sealed class Category : Entity<int>
{

    public Category()
    {
        
    }

    public Category(int id, string name, string description)
    {
        Id = id;
        Name = name;
        Description = description;
    }


    public string Description { get; set; }

}

