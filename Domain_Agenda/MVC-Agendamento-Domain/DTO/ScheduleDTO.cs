using MVC_Agendamento_Domain.Entities;
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

		[DisplayName("Status")]
		public int statusId { get; set; }

		[DisplayName("Data")]
		public DateTime date { get; set; }

		[DisplayName("Confirmação")]
		public bool confirmedQuery { get; set; }


		public virtual Status? status { get; set; }
		public virtual Patient? patient { get; set; }
		public virtual Doctor? doctor { get; set; }

		public Schedule mapToEntity()
		{
			return new Schedule
			{
				Id = id,
				PatientId = patientId,
				DoctorId = doctorId,
				Date = date,
				ConfirmedQuery = confirmedQuery,
				StatusId = statusId,
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
				statusId = schedule.StatusId,
			};
		}
	}
}