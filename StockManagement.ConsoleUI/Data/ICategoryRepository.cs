using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public interface ICategoryRepository 
{
    List<Category> GetAll();
    Category? GetById(int id);

    Category Add(Category category);
    Category Update(Category category);
    Category Delete(int id);

}
