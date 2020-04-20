using System;

namespace Vestas.Freelancer.Domain.Models.Entities
{
    public class AppointmentModel : BaseEntity
    {
        public string ProjectName { get; set; }
        public DateTime AppointmentStartTime { get; set; }
        public DateTime AppointmentEndTime { get; set; }

        public int GetAppointmentDurationsInMinutes()
        {
            return 0;
        }
    }
}
