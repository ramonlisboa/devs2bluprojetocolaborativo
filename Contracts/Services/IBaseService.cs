using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.Contracts.Services
{
    public interface IBaseService<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int? id);
        Task<int> Save(T entity);
        Task<int> Delete(int id);
    }
}
