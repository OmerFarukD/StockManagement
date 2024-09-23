

using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public sealed class CategoryData : BaseRepository
{

   

    public List<Category> GetAll()
    {
         return Categories();
    }

}
