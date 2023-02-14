using Register.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Register.Domain.DTO
{
    public class ConditionDTO
    {
        [Display(Name = "Id")]
        public int id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }
        public virtual ICollection<PatientDTO>? patientList { get; set; }
        public Condition mapToEntity()
        {
            return new Condition
            {
                Id = this.id,
                Name = this.name,
            };
        }
        public ConditionDTO maptoDTO(Condition condition)
        {
            return new ConditionDTO
            {
                id = condition.Id,
                name = condition.Name,
            };
        }
    }
}
