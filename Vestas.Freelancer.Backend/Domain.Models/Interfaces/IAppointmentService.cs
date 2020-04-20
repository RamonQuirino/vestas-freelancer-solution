namespace Vestas.Freelancer.Domain.Models.Interfaces
{	
	using System.Collections.Generic;
	using Vestas.Freelancer.Domain.Models.Entities;

	public interface IAppointmentService 
	{
		AppointmentModel Save(AppointmentModel obj);

		AppointmentModel Select(int id);

		IEnumerable<AppointmentModel> SelectAll();
	}
}
