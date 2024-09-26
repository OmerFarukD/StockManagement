namespace StockManagement.ConsoleUI.Models;

public sealed  class Product : Entity<Guid>
{
    public Product()
    {
        
    }


    public Product(Guid id, int categoryId, string name, double price, int stock)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}
