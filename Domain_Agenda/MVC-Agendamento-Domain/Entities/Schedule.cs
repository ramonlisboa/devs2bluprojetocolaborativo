using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.Entities {
    public class Schedule
    {

        public int Id { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public bool ConfirmedQuery { get; set; }

        [DisplayName("StatusID")]
        public int StatusId { get; set; }
        public virtual Status? Status { get; set; }
        public virtual Patient? Patient { get; set; }  //Será alterado para a entidade correta
        public virtual Doctor? Doctor { get; set; }
    }
}
