
using StockManagement.ConsoleUI.Models;
using StockManagement.ConsoleUI.Models.Dtos;

namespace StockManagement.ConsoleUI.Data;

public interface IProductData : IRepository<Product,Guid>
{
    double TotalProductPriceSum();
    List<Product> GetAllPriceRange(double min, double max);
    List<Product> GetAllProductNameContains(string text);
    List<Product> GetAllProductsByStockRange(int min, int max);
    List<Product> GetAllProductsOrderByAscendingName();
    List<Product> GetAllProductsOrderByDescendingName();
    Product GetExpensiveProduct();
    Product GetCheapProduct();
    List<ProductDetailDto> GetDetails(List<Category> categories);
    List<ProductDetailDto> GetDetailsV2(List<Category> categories);
    ProductDetailDto? GetDetailById(Guid id, List<Category> categories);

    List<string> GetAllProductNames();
}
