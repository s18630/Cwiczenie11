﻿using System;
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


        [Route("api/doctors")]
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


    }
}
