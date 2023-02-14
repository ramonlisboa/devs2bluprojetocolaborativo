using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Status {

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Service>? Service { get; set; }

        public ICollection<Schedule>? Schedule { get; set; }

    }
}
