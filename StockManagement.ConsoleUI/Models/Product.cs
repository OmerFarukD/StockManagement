namespace StockManagement.ConsoleUI.Models;

public record Product(
    int Id,
    int categoryId,
    string Name,
    double Price,
    int Stock);
