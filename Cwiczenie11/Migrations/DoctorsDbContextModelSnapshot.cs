﻿// <auto-generated />
using System;
using Cwiczenie11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cwiczenie11.Migrations
{
    [DbContext(typeof(DoctorsDbContext))]
    partial class DoctorsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cwiczenie11.Models.Doctor", b =>
                {
                    b.Property<int>("idDoctor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idDoctor");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            idDoctor = 1,
                            Email = "jnp@wp.pl",
                            FirstName = "Jan",
                            LastName = "Niezbytny"
                        },
                        new
                        {
                            idDoctor = 2,
                            Email = "paw@wp.pl",
                            FirstName = "Paweł",
                            LastName = "Borek"
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Medicament", b =>
                {
                    b.Property<int>("IdMedicament")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMedicament");

                    b.ToTable("Medicaments");

                    b.HasData(
                        new
                        {
                            IdMedicament = 1,
                            Description = "Lek",
                            Name = "Paracetamol",
                            Type = "doraxny"
                        },
                        new
                        {
                            IdMedicament = 2,
                            Description = "Lek",
                            Name = "Nospa",
                            Type = "doraxny"
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Patient", b =>
                {
                    b.Property<int>("idPatient")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idPatient");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            idPatient = 1,
                            BirthDate = new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Janusz",
                            LastName = "Nierobek"
                        },
                        new
                        {
                            idPatient = 2,
                            BirthDate = new DateTime(2009, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Michał",
                            LastName = "Boreczko"
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Prescription", b =>
                {
                    b.Property<int>("IdPrescription")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdDoctor")
                        .HasColumnType("int");

                    b.Property<int?>("IdPatient")
                        .HasColumnType("int");

                    b.HasKey("IdPrescription");

                    b.HasIndex("IdDoctor");

                    b.HasIndex("IdPatient");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            IdPrescription = 1,
                            Date = new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            IdPrescription = 2,
                            Date = new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified),
                            DueDate = new DateTime(2000, 6, 1, 7, 47, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Prescription_Medicament", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Dose")
                        .HasColumnType("int");

                    b.Property<int?>("IdMedicament")
                        .HasColumnType("int");

                    b.Property<int?>("IdPrescription")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("IdMedicament");

                    b.HasIndex("IdPrescription");

                    b.ToTable("Prescriptions_Medicaments");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Details = "details1",
                            Dose = 1
                        },
                        new
                        {
                            id = 2,
                            Details = "details2",
                            Dose = 2
                        });
                });

            modelBuilder.Entity("Cwiczenie11.Models.Prescription", b =>
                {
                    b.HasOne("Cwiczenie11.Models.Doctor", "doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdDoctor");

                    b.HasOne("Cwiczenie11.Models.Patient", "patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("IdPatient");
                });

            modelBuilder.Entity("Cwiczenie11.Models.Prescription_Medicament", b =>
                {
                    b.HasOne("Cwiczenie11.Models.Medicament", "Medicament")
                        .WithMany("Prescription_Medicaments")
                        .HasForeignKey("IdMedicament");

                    b.HasOne("Cwiczenie11.Models.Prescription", "Prescription")
                        .WithMany("Prescription_Medicaments")
                        .HasForeignKey("IdPrescription");
                });
#pragma warning restore 612, 618
        }
    }
}
