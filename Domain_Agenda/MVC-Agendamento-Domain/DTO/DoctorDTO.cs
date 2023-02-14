using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Agendamento_Domain.DTO {
    public class DoctorDTO
    {
        [Display(Name = "Id")]
        [Required(ErrorMessage = "{0} is required")]
        public int id { get; set; }

        [Display(Name = "Specialty")]
        [Required(ErrorMessage = "{0} is required")]
        public int specialtyId { get; set; }

        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "CRM")]
        public string crm { get; set; }

        [Display(Name = "PersonId")]
        public int personId { get; set; }


        public Doctor mapToEntity()
        {
            return new Doctor()
            {
                Id = id,
                SpecialtyId = specialtyId,
                CNPJ = cnpj,
                CRM = crm,
                PersonId = personId

            };
        }
        public DoctorDTO mapToDTO(Doctor doctor)
        {
            return new DoctorDTO()
            {
                id = doctor.Id,
                specialtyId = doctor.SpecialtyId,
                cnpj = doctor.CNPJ,
                crm = doctor.CRM,
                personId = doctor.PersonId
            };
        }
    }
}
