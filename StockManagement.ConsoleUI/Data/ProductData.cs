using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public class ProductData
{

   private List<Product> products = new List<Product>()
{
    new Product(1,"Beymen Takım Elbise",15000,250),
    new Product(2,"Prada Çanta",60000,10),
    new Product(3,"Hk Vision Drone",400000,25),
    new Product(4,"Dyson Süpürge",32000,200),
    new Product(5,"Karaca Vazo",500,1000),
    new Product(6,"Kütahya Porselen Ayna",1500,200),
    new Product(7, "Adidas Futbol Topu",5000,1254),
    new Product(8,"Delta Yoga Matı",2000,531)
};

   public Product Add(Product product)
    {
        products.Add(product);
        return product;
    }

   public double TotalProductPriceSum()
    {
        double total = products.Sum(x => x.Price);
        return total;
    }

   public List<Product> GetAllPriceRange(double min, double max)
    {
        List<Product> filteredProducts = new List<Product>();

        foreach (Product product in products)
        {
            if (product.Price >= min && product.Price <= max)
            {
               filteredProducts.Add(product);
            }
        }
        return filteredProducts;
    }
    
    public List<Product> GetAllProductNameContains(string text)
    {
        List<Product> filteredProducts = new List<Product>();

        foreach (Product product in products) 
        {
            if (product.Name.Contains(text,StringComparison.InvariantCultureIgnoreCase))
            {
                filteredProducts.Add(product); 
            }
        }
        return filteredProducts;
    }

    public Product? GetById(int id)
    {
        Product? product = null;
        foreach (Product item in products)
        {
            if (item.Id == id)
            {
                product = item;
                break;
            }
        }
        return product;
    }


    public Product Delete(int id)
    {
        Product? product = GetById(id);

        if (product is not null)
        {
            products.Remove(product);
        }

        return product;
    }

   public List<Product> GetAll()
    {
        return products;
    }
}
