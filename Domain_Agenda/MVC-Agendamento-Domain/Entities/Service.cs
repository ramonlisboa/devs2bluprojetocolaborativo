using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MVC_Agendamento_Domain.Entities {
    public class Service {

        public int Id { get; set; }
        public int ScheduleId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public int StatusId { get; set; }
        public int ServiceNumbe { get; set; }
        public DateTime Date { get; set; }
        public string? Evaluation { get; set; }

        public int MedicalRecord { get; set; }
        public virtual Status? Status { get; set; }

        public virtual Patient? Patient { get; set; } //ok
        public virtual Doctor? Doctor { get; set; } //ok


    }
}
