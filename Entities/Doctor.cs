using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public int SpecialtyId { get; set; }
        public string CNPJ { get; set; }
        public string CRM { get; set; }
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }
        public virtual Specialty? Specialty { get; set; }
    }
}
