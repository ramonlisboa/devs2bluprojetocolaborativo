using MVC_Agendamento_Domain.Entities;
using MVC_Agendamento_Domain.Utils.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO
{
    public class ScheduleDTO
    {
		[DisplayName("Id")]
		public int id { get; set; }

		[DisplayName("Id Paciente")]
		public int patientId { get; set; }

		[DisplayName("Id Médico")]
		public int doctorId { get; set; }

		[DisplayName("Data")]
		public DateTime date { get; set; }

		[DisplayName("Confirmação")]
		public bool confirmedQuery { get; set; }

		[DisplayName("Status")]
		public EnumStatus status { get; set; }

		

        public virtual string? patient { get; set; }  //Será alterado para a entidade correta
		public virtual string? doctor { get; set; }

		public Schedule mapToEntity()
        {
            return new Schedule
            {
                Id = id,
				PatientId = patientId,
				DoctorId = doctorId,
                Date = date,
				ConfirmedQuery = confirmedQuery,
                Status = status,
            };
        }
        public ScheduleDTO mapToDTO(Schedule schedule)
        {
            return new ScheduleDTO
            {
                id = schedule.Id,
				patientId = schedule.PatientId,
				doctorId = schedule.DoctorId,
				date = schedule.Date,
				confirmedQuery = schedule.ConfirmedQuery,
				status = schedule.Status,
			};
        }
    }
}
