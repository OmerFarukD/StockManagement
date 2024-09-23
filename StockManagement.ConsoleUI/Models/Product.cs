namespace StockManagement.ConsoleUI.Models;

public sealed  class Product
{
    public Product()
    {
        
    }


    public Product(int id, int categoryId, string name, double price, int stock)
    {
        Id = id;
        CategoryId = categoryId;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
}
