using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Agendamento_Domain.DTO {
    public class SpecialtyDTO
    {
        [Display(Name = "Id")]
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        public virtual ICollection<DoctorDTO>? doctorList { get; set; }
        public Specialty mapToEntity()
        {
            return new Specialty
            {
                Id = id,
                Name = name,
            };
        }
        public SpecialtyDTO mapToDTO(Specialty specialty)
        {
            return new SpecialtyDTO
            {
                id = specialty.Id,
                name = specialty.Name,
            };
        }
    }
}
