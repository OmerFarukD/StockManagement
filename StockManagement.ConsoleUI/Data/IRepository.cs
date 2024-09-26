using StockManagement.ConsoleUI.Models;

namespace StockManagement.ConsoleUI.Data;

public interface IRepository<TEntity,TId>
    where TEntity : Entity<TId> , new()
{
    List<TEntity> GetAll();
    TEntity? GetById(TId id);

    TEntity Add(TEntity category);
    TEntity Update(TEntity category);
    TEntity Delete(TId id);
}
