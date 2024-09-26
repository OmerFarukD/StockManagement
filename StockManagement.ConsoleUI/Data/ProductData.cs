using StockManagement.ConsoleUI.Models;
using StockManagement.ConsoleUI.Models.Dtos;
using StockManagement.ConsoleUI.Service;

namespace StockManagement.ConsoleUI.Data;

public sealed class ProductData:  BaseRepository ,IProductData
{
   List<Product> products()
    {
        return Products();
    }

    List<Category> categories()
    {
        return Categories();
    }


    //List<Category> categories = new List<Category>()
    // {
    //     new Category(1,"Elbise","Elbise Açıklaması"),
    //     new Category(2,"Elektronik","Elektronik Açıklama"),
    //     new Category(3,"Dekorasyon","Dekorasyon Açıklama"),
    //     new Category(4,"Spor Aletleri","Spor Aletleri Açıklama"),

    // };

    public Product Add(Product product)
    {
        products().Add(product);
        return product;
    }

   public double TotalProductPriceSum()
    {
        double total = products().Sum(x => x.Price);
        return total;
    }

   public List<Product> GetAllPriceRange(double min, double max)
    {
        // 1. Yöntem
        //List<Product> filteredProducts = new List<Product>();

        //foreach (Product product in products)
        //{
        //    if (product.Price >= min && product.Price <= max)
        //    {
        //       filteredProducts.Add(product);
        //    }
        //}
        //return filteredProducts;

       
        var filteredProducts = products().Where(x => x.Price <= max && x.Price >= min).ToList();
        return filteredProducts;

        // Where(lambda[Dönüş tipi : bool]) : Verilerin filtrelenmesi için kullanılır.
    }
    
    public List<Product> GetAllProductNameContains(string text)
    {
        // 1. Yöntem
        //List<Product> filteredProducts = new List<Product>();

        //foreach (Product product in products) 
        //{
        //    if (product.Name.Contains(text,StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        filteredProducts.Add(product); 
        //    }
        //}
        //return filteredProducts;


        // FindAll(lambda[Dönüş tipi : bool]) : Where.ToList den farkı işin sonunda sadece Liste döndürür.
        var filteredProducts = products().FindAll(x=> x.Name.Contains(text));
        return filteredProducts;
    }

    public Product? GetById(Guid id)
    {
        //1. Yöntem
        //Product? product = null;
        //foreach (Product item in products)
        //{
        //    if (item.Id == id)
        //    {
        //        product = item;
        //        break;
        //    }
        //}
        //return product;

        // L1 
         Product? product = products().SingleOrDefault(x=>x.Id==id);

         // Product? product = products.Where(x => x.Id == id).SingleOrDefault();

        //Product? product = products.FirstOrDefault(x=> x.Id ==id);
        return product;
    }


    public Product Delete(Guid id)
    {
        Product? product = GetById(id);

        if (product is not null)
        {
            products().Remove(product);
        }
        else
        {
            return null;
        }

        return product;



    }

   public List<Product> GetAll()
    {
        return products();
    }

    public List<Product> GetAllProductsByStockRange(int min, int max)
    {
        List<Product> filtered = products().FindAll(x=> x.Stock<=max && x.Stock>=min);
        return filtered;
    }


    public List<Product> GetAllProductsOrderByAscendingName()
    {
        List<Product> orderBy = products().OrderBy(x=> x.Name).ToList();
        return orderBy;
    }

    public List<Product> GetAllProductsOrderByDescendingName()
    {
        List<Product> orderBy = products().OrderByDescending(x => x.Name).ToList();
        return orderBy;
    }

    public Product GetExpensiveProduct()
    {
        Product product = products().OrderBy(x => x.Price).LastOrDefault();
        return product;
    }

    public Product GetCheapProduct()
    {
        Product product = products().OrderBy(x => x.Price).FirstOrDefault();
        return product;
    }

    public List<ProductDetailDto> GetDetails(List<Category> categories)
    {
        var result = from p in products()
                     join c in categories
                     on p.CategoryId equals c.Id


                     select new ProductDetailDto(
                         Id: p.Id,
                         categoryName: c.Name,
                         Name: p.Name,
                         Price: p.Price,
                         Stock: p.Stock
                         );

        return result.ToList();
    }

    public List<ProductDetailDto> GetDetailsV2(List<Category> categories)
    {
        List<ProductDetailDto> details =
            products().Join(categories,
            p => p.CategoryId,
            c => c.Id,
            (pr, ca) => new ProductDetailDto(
                         Id: pr.Id,
                         categoryName: ca.Name,
                         Name: pr.Name,
                         Price: pr.Price,
                         Stock: pr.Stock
                         )
            ).ToList();
        return details;
    }

    public ProductDetailDto? GetDetailById(Guid id,List<Category> categories)
    {

        var result = from p in products()
                     where p.Id == id
                     join c in categories
                     on p.CategoryId equals c.Id

                     select new ProductDetailDto(
                         Id: p.Id,
                         categoryName: c.Name,
                         Name: p.Name,
                         Price: p.Price,
                         Stock: p.Stock
                         );

        return result.FirstOrDefault();


    }

    public List<string> GetAllProductNames()
    {
        List<string> productName = products().Select(x=> x.Name).ToList();
        return productName;
    }

    public Product Update(Product category)
    {
        throw new NotImplementedException();
    }
}
