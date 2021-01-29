using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenie11.Models
{
    public class DoctorsDbContext : DbContext
    {

        public DbSet<Doctor> Doctors {get; set;}
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }

        public DbSet<Prescription> Prescriptions { get; set; }

        public DbSet<Prescription_Medicament> Prescriptions_Medicaments { get; set; }

        public DoctorsDbContext()
        {


        }

        public DoctorsDbContext(DbContextOptions options)
        :base(options)
        {
           

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
              base.OnModelCreating(modelBuilder);

            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { idDoctor = 1, FirstName = "Jan",LastName = "Niezbytny", Email="jnp@wp.pl" });
            doctors.Add(new Doctor { idDoctor = 2, FirstName = "Paweł", LastName = "Borek", Email = "paw@wp.pl" });

            modelBuilder.Entity<Doctor>()
                        .HasData(doctors);



            DateTime date1 = new DateTime(2000, 6, 1, 7, 47, 0);
            DateTime date2 = new DateTime(2009, 6, 1, 7, 47, 0);

            var patients = new List<Patient>();
            patients.Add(new Patient { idPatient = 1, FirstName = "Janusz", LastName = "Nierobek", BirthDate = date1 });

            patients.Add(new Patient { idPatient = 2, FirstName = "Michał", LastName = "Boreczko", BirthDate =date2});

            modelBuilder.Entity<Patient>()
                        .HasData(patients);


            var medicaments = new List<Medicament>();
            medicaments.Add(new Medicament { IdMedicament = 1, Name = "Paracetamol", Description = "Lek",Type= "doraxny" });

            medicaments.Add(new Medicament { IdMedicament = 2, Name = "Nospa", Description = "Lek", Type = "doraxny" });

            modelBuilder.Entity<Medicament>()
                        .HasData(medicaments);




            var prescriptions = new List<Prescription>();
            prescriptions.Add(new Prescription { IdPrescription = 1, Date = date1, DueDate = date1, doctor = null, patient = null });

            prescriptions.Add(new Prescription { IdPrescription = 2, Date = date1, DueDate = date1, doctor = null, patient = null });

            modelBuilder.Entity<Prescription>()
                        .HasData(prescriptions);

            

            
            var prescription_Medicaments = new List<Prescription_Medicament>();
            prescription_Medicaments.Add(new Prescription_Medicament { id = 1, Dose = 1, Details = "details1", Prescription = null, Medicament = null });

            prescription_Medicaments.Add(new Prescription_Medicament { id = 2, Dose = 2, Details = "details2", Prescription = null, Medicament = null });

            modelBuilder.Entity<Prescription_Medicament>()
                        .HasData(prescription_Medicaments);



            














    }
}
}
