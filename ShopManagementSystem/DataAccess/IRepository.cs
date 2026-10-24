using System.Collections.Generic;
using ShopManagementSystem.Models;

namespace ShopManagementSystem.DataAccess
{
    // Standard CRUD operations every table repository provides.
    public interface IRepository<T> where T : Entity
    {
        List<T> GetAll();
        List<T> Search(string keyword);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
