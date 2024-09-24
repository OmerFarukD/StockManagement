

using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public sealed class CategoryData : BaseRepository, ICategoryRepository
{
    public Category Add(Category category)
    {
        throw new NotImplementedException();
    }

    public Category Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetAll()
    {
         return Categories();
    }

    public Category? GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Category Update(Category category)
    {
        throw new NotImplementedException();
    }
}
