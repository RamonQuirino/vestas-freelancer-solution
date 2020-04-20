namespace Vestas.Freelancer.Infraestructure.Repository
{
    using Microsoft.EntityFrameworkCore;    
    using Vestas.Freelancer.Domain.Models.Entities;
    using Vestas.Freelancer.Infraestructure.Repository.Mapping;

    public class DatabaseContext: DbContext
    {

        protected DatabaseContext(DbContextOptions options) : base(options) { }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : this((DbContextOptions)options)
        {
        }

        public DbSet<AppointmentModel> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AppointmentModel>(new AppointmentMapping().Configure);
        }
    }
}
