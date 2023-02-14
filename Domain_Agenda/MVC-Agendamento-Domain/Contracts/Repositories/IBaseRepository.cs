using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Contract.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> FindAll();
        IQueryable<T> GetAll();
        Task<T> FindById(int id);
        Task<int> Save(T entity);
        Task<int> Update(T entity);
        Task<int> Delete(T entity);
    }
}
