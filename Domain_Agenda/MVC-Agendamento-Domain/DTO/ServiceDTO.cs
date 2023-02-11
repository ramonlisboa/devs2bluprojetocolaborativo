using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO {
    public class ServiceDTO {

        [DisplayName("Id")]
        public int id { get; set; }

        [DisplayName("Id Agenda")]
        public int idSchedule { get; set; }

        [DisplayName("Id Paciente")]
        public int idPatient { get; set; }

        [DisplayName("Id Medico")]
        public int idDoctor { get; set; }

        [DisplayName("Paciente")]
        public virtual string? patient { get; set; }

        [DisplayName("Medico")]
        public virtual string? doctor { get; set; }

        [DisplayName("Numero do Atendimento")]
        public int serviceNumbe { get; set; }

        [DisplayName("Data do Atendimento")]
        public DateTime date { get; set; }

        [DisplayName("Status do atendimento")]
        public EnumStatus status { get; set; }

        [DisplayName("Avaliação")]
        public string? evaluation { get; set; }

        public int medicalRecord { get; set; }


        public Service mapToEntity() {
            return new Service {
                Id = id,
                IdSchedule = idSchedule,
                IdPatient = idPatient,
                IdDoctor = idDoctor,
                Patient = patient,
                Doctor = doctor,
                ServiceNumbe = serviceNumbe,
                Date = date,
                Status = status,
                Evaluation = evaluation,
                MedicalRecord = medicalRecord,

            };
        }
        public ServiceDTO mapToDTO(Service service) {
            return new ServiceDTO {
                idSchedule = service.IdSchedule,
                idPatient = service.IdPatient,
                idDoctor = service.IdDoctor,
                patient = service.Patient,
                doctor = service.Doctor,
                serviceNumbe = service.ServiceNumbe,
                date = service.Date,
                status = service.Status,
                evaluation = service.Evaluation,
                medicalRecord= service.MedicalRecord,
            };

        }

    }
}
