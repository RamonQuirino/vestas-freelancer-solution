using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vestas.Freelancer.Domain.Models;
using Vestas.Freelancer.Domain.Models.Entities;
using Vestas.Freelancer.Domain.Models.Interfaces;

namespace Presentation.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FreelancerController : ControllerBase
    {

        private readonly ILogger<FreelancerController> _logger;
        private readonly IAppointmentRepository _appointmentRepository;

        public FreelancerController(
            ILogger<FreelancerController> logger, 
            IAppointmentRepository appointmentRepository)
        {
            _logger = logger;
            _appointmentRepository = appointmentRepository;
        }

        [HttpGet]
        public IEnumerable<AppointmentModel> Get()
        {
            return _appointmentRepository.SelectAll();
        }

        [HttpPost]
        public AppointmentModel Post(AppointmentModel model)
        {
            return _appointmentRepository.Save(model);
        }
    }
}
