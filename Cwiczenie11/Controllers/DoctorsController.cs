using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenie11.DTOs;
using Cwiczenie11.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenie11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private readonly DoctorsDbContext _context;
        public DoctorsController(DoctorsDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors.ToList());
        }
        // pobierać dane lekarze, dodawać nowego lekarza, modyfikować dane lekarza i usuwać lekarza (4 końcówki).



        [HttpPost]
        public IActionResult GetDoctors(DoctorResponse response)
        {


            var res = _context.Doctors
                      .Where(d => d.idDoctor == response.idDoctor)
                      .FirstOrDefault();

          
            response.idDoctor = res.idDoctor;
            response.FirstName = res.FirstName;
            response.LastName = res.LastName;
            response.Email = res.Email;

            return Ok(response);
        }
    }
}
