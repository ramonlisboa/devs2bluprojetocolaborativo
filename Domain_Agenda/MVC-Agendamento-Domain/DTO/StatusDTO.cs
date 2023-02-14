using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Agendamento_Domain.DTO {
    public class StatusDTO {

        [Display(Name = "Id")]
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }

         public ICollection<Service>? Service { get; set; }


        public Status mapToEntity() {
            return new Status {
                Id = id,
                Name = name,
            };
        }
        public StatusDTO mapToDTO(Status status) {
            return new StatusDTO {
                id = status.Id,
                name = status.Name,
            };
        }
    }
}

