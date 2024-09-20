

using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public class CategoryData
{

    List<Category> categories = new List<Category>()
     {
         new Category(1,"Elbise","Elbise Açıklaması"),
         new Category(2,"Elektronik","Elektronik Açıklama"),
         new Category(3,"Dekorasyon","Dekorasyon Açıklama"),
         new Category(4,"Spor Aletleri","Spor Aletleri Açıklama"),

     };

    public List<Category> GetAll()
    {
         return categories;
    }

}
