namespace Vestas.Freelancer.Domain.Services.Services
{
    using Vestas.Freelancer.Domain.Models.Interfaces;
    using Vestas.Freelancer.Domain.Models.Entities;
    using System.Collections.Generic;

    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository) {
            this.appointmentRepository = appointmentRepository;
        }

        public AppointmentModel Save(AppointmentModel obj)
        {
            return appointmentRepository.Save(obj);
        }

        public AppointmentModel Select(int id)
        {
            return appointmentRepository.Select(id);
        }

        public IEnumerable<AppointmentModel> SelectAll()
        {
            return appointmentRepository.SelectAll();
        }
    }
}
