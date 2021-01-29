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
    
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private readonly DoctorsDbContext _context;
        public DoctorsController(DoctorsDbContext context)
        {
            _context = context;
        }

        [Route("api/doctors")]
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors.ToList());
        }
        // pobierać dane lekarze, dodawać nowego lekarza, modyfikować dane lekarza i usuwać lekarza (4 końcówki).


        [Route("api/doctor")]
        [HttpPost]
        public IActionResult GetDoctors(DoctorResponse request)
        {


            var res = _context.Doctors
                      .Where(d => d.idDoctor == request.idDoctor)
                      .FirstOrDefault();
            if (res == null)
            {
                return BadRequest("Nie ma takiego doktora");
            }

            var response = new DoctorResponse();

            response.idDoctor = res.idDoctor;
            response.FirstName = res.FirstName;
            response.LastName = res.LastName;
            response.Email = res.Email;

            return Ok(response);
        }



        [Route("api/doctors/insert")]
        [HttpPost]
        public IActionResult InsertDoctors(InsertDoctorRequest request)
        {


            //sprawdz czy jest takie id jak jest to zwróć błąd

          

            var doctor = new Doctor()
            {
     
                FirstName=request.FirstName,
                LastName=request.LastName,
                Email=request.Email
            };

  
            _context.Doctors.Add(doctor);

            _context.SaveChanges(); //1 transakcja -> 2 INS

            var res = _context.Doctors
                     .Where(d => d.FirstName == request.FirstName && d.LastName== request.LastName)
                     .FirstOrDefault();

            if (res == null)
            {
                return BadRequest("Nie ma takiego doktora");
            }

            var response = new DoctorResponse();

            response.idDoctor = res.idDoctor;
            response.FirstName = res.FirstName;
            response.LastName = res.LastName;
            response.Email = res.Email;

            return Ok(response);
        }



        [Route("api/doctors/delete")]
        [HttpPost]
        public IActionResult DeleteDoctor(DoctorResponse response)
        {
            var res = _context.Doctors
                     .Where(d => d.idDoctor == response.idDoctor)
                     .FirstOrDefault();
            if (res == null)
            {
                return BadRequest("Nie ma takiego doktora");
            }


         /*   var d = new Doctor
            {
                idDoctor = response.idDoctor
            };
          //  _context.Attach();*/
            _context.Remove(res);
          

            _context.SaveChanges();

            return Ok("Doktor o id : " + response.idDoctor+ " został usunięty");
        }



        [Route("api/doctors/modify")]
        [HttpPost]
        public IActionResult ModifyDoctor(ModifyDoctorRequest request)
        {

            /*    var d1 = _context.Doctors
                    .Where(d => d.idDoctor==request.idDoctor )
                         .FirstOrDefault();

                    d1.FirstName = request.FirstName;


                    d1.LastName = request.LastName;



                    d1.Email = request.Email;




                _context.SaveChanges(); //...



               */
            var doctor = new Doctor
                      {
                          idDoctor=request.idDoctor,

                          FirstName = request.FirstName,
                          LastName = request.LastName,
                          Email = request.Email


                      };

                      _context.Attach(doctor);

                      if (request.FirstName != null)
                      {
                          _context.Entry(doctor).Property("FirstName").IsModified = true;

                      }

                      if (request.LastName != null)
                      {
                          _context.Entry(doctor).Property("LastName").IsModified = true;

                      }

                      if (request.Email != null)
                      {
                          _context.Entry(doctor).Property("Email").IsModified = true;

                      }

                      _context.SaveChanges();

                     

            return Ok("Dokonano modyfikacji id: " +request.idDoctor );





















        }


    }
}
