namespace Vestas.Freelancer.Infraestructure.Repository.Mapping
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Vestas.Freelancer.Domain.Models.Entities;

    public class AppointmentMapping : IEntityTypeConfiguration<AppointmentModel>
	{
		public void Configure(EntityTypeBuilder<AppointmentModel> builder)
		{

			builder.HasKey(c => c.Id);

			builder.Property(c => c.ProjectName)
				.IsRequired();

			builder.Property(c => c.AppointmentStartTime)
				.IsRequired();

			builder.Property(c => c.AppointmentEndTime)
				.IsRequired();				
		}
	}
}
