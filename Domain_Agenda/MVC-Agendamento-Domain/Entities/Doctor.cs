using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Doctor
    {
        public int Id { get; set; }
        public virtual Specialty? SpecialtyList { get; set; }
        public int SpecialtyId { get; set; }
        public string CNPJ { get; set; }
        public string CRM { get; set; }
        public int PersonId { get; set; }

        //public virtual Person? Person { get; set; }

        public virtual ICollection<Service>? Service { get; set; }
        public virtual ICollection<Schedule>? Schedule { get; set; }

        public bool HasNoKey() {
            throw new NotImplementedException();
        }
    }
}
