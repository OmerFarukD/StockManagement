using StockManagement.ConsoleUI.Data;
using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Service;

public class CategoryService
{
    CategoryData categoryData = new CategoryData();


    public List<Category> GetAllCategories()
    {
        return categoryData.GetAll();
    }

}
