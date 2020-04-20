namespace Vestas.Freelancer.Infraestructure.Repository
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using Vestas.Freelancer.Domain.Models.Entities;
    using Vestas.Freelancer.Domain.Models.Interfaces;

    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DatabaseContext databaseContext;

        public AppointmentRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public AppointmentModel Save(AppointmentModel obj)
        {
            if (obj.Id == 0)
            {
                databaseContext.Add(obj);                
            }
            else
            {
                databaseContext.Entry(obj).State = EntityState.Modified;
            }
            databaseContext.SaveChanges();
            return obj;
        }

        public AppointmentModel Select(int id)
        {
            return databaseContext.Appointments.Find(id);
        }

        public IEnumerable<AppointmentModel> SelectAll()
        {
            return databaseContext.Appointments;
        }
    }
}
