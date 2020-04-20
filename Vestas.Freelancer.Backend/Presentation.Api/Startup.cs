namespace Presentation.Api
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Vestas.Freelancer.Domain.Models.Interfaces;
    using Vestas.Freelancer.Domain.Services.Services;
    using Vestas.Freelancer.Infraestructure.Repository;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddCors(options =>
            {
                options.AddDefaultPolicy(
                    builder =>
                    {
                        builder
                            .WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();                        
                    });
            });

            //services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("LocalDatabase"));
            services.AddDbContext<DatabaseContext>(opt => opt.UseInMemoryDatabase("LocalDatabase"));

            services.AddTransient<IAppointmentService, AppointmentService>();
            services.AddTransient<IAppointmentRepository, AppointmentRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
