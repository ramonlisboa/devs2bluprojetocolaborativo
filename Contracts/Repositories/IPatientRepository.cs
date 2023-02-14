using Register.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.Contracts.Repositories
{
    public interface IPatientRepository : IBaseRepository<Patient>
    {
    }
}
