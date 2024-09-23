using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public abstract class BaseRepository
{
   private List<Category> categories = new List<Category>()
     {
         new Category(1,"Elbise","Elbise Açıklaması"),
         new Category(2,"Elektronik","Elektronik Açıklama"),
         new Category(3,"Dekorasyon","Dekorasyon Açıklama"),
         new Category(4,"Spor Aletleri","Spor Aletleri Açıklama"),

     };
    private List<Product> products = new List<Product>()
{
    new Product(1,1,"Beymen Takım Elbise",15000,250),
    new Product(2,1,"Prada Çanta",60000,10),
    new Product(3,2,"Hk Vision Drone",400000,25),
    new Product(4,2,"Dyson Süpürge",32000,200),
    new Product(5,3,"Karaca Vazo",500,1000),
    new Product(6,3,"Kütahya Porselen Ayna",1500,200),
    new Product(7,4, "Adidas Futbol Topu",5000,1254),
    new Product(8,4,"Delta Yoga Matı",2000,531)
};


    public List<Category> Categories()
    {
        return categories;
    }

    public List<Product> Products()
    { 
    return products;
    }

}
