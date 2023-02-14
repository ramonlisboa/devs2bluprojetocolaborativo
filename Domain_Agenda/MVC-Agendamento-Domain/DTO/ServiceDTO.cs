using MVC_Agendamento_Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Agendamento_Domain.DTO
{

	public class ServiceDTO
	{
		[DisplayName("Id")]
		public int id { get; set; }

		[DisplayName("Id Agenda")]
		public int scheduleId { get; set; }

		[DisplayName("Id Paciente")]
		public int patientId { get; set; }

		[DisplayName("Id Medico")]
		public int doctorId { get; set; }

		[DisplayName("Status")]
		public int statusId { get; set; }

		[DisplayName("Paciente")]
		public virtual Patient? patient { get; set; }

		[DisplayName("Medico")]
		public virtual Doctor? doctor { get; set; }

		[DisplayName("Status do atendimento")]
		public virtual Status? status { get; set; }

		[DisplayName("Numero do Atendimento")]
		public int serviceNumbe { get; set; }

		[DisplayName("Data do Atendimento")]
		public DateTime date { get; set; }


		[DisplayName("Avaliação")]
		public string? evaluation { get; set; }

		public int medicalRecord { get; set; }
		public Service mapToEntity()
		{
			return new Service
			{
				Id = id,
				ScheduleId = scheduleId,
				PatientId = patientId,
				DoctorId = doctorId,
				StatusId = statusId,
				Patient = patient,
				Doctor = doctor,
				ServiceNumbe = serviceNumbe,
				Date = date,
				Status = status,
				Evaluation = evaluation,
				MedicalRecord = medicalRecord,

			};
		}
		public ServiceDTO mapToDTO(Service service)
		{
			return new ServiceDTO
			{
				scheduleId = service.ScheduleId,
				patientId = service.PatientId,
				doctorId = service.DoctorId,
				statusId = service.StatusId,
				patient = service.Patient,
				doctor = service.Doctor,
				serviceNumbe = service.ServiceNumbe,
				date = service.Date,
				status = service.Status,
				evaluation = service.Evaluation,
				medicalRecord = service.MedicalRecord,
			};
		}
	}
}