using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement.ConsoleUI.Models.Dtos
{
    public record ProductDetailDto(
    int Id,
    string categoryName,
    string Name,
    double Price,
    int Stock);
}
