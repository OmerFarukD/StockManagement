
using StockManagement.ConsoleUI.Models;
using StockManagement.ConsoleUI.Models.Dtos;

namespace StockManagement.ConsoleUI.Data;

public interface IProductData
{
    Product Add(Product product);

    double TotalProductPriceSum();
    List<Product> GetAllPriceRange(double min, double max);
    List<Product> GetAllProductNameContains(string text);
    Product? GetById(int id);
    Product Delete(int id);
    List<Product> GetAll();
    List<Product> GetAllProductsByStockRange(int min, int max);
    List<Product> GetAllProductsOrderByAscendingName();
    List<Product> GetAllProductsOrderByDescendingName();
    Product GetExpensiveProduct();
    Product GetCheapProduct();
    List<ProductDetailDto> GetDetails(List<Category> categories);
    List<ProductDetailDto> GetDetailsV2(List<Category> categories);
    ProductDetailDto? GetDetailById(int id, List<Category> categories);

    List<string> GetAllProductNames();
}
