using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.Contracts.Repositories
{
    public interface IBaseRepository<T> where T: class
    {
        IQueryable<T> GetAll();
        Task<T> GetById(int? id);
        Task<int> Save(T entity);
        Task<int> Delete(T entity);
        Task<int> Update(T entity);
    }
}
