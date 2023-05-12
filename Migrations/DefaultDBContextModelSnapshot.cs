﻿// <auto-generated />
using System;
using Capstonep2.Infrastructure.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Capstonep2.Migrations
{
    [DbContext(typeof(DefaultDBContext))]
    partial class DefaultDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Appointment", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid?>("PatientID")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("PurposeId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("SymptomId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Visit")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.HasIndex("PurposeId");

                    b.HasIndex("SymptomId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            ID = new Guid("3ce371f9-dc79-4623-b84f-0b2fe7c99962"),
                            EndTime = new DateTime(2023, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            SymptomId = new Guid("32d18f17-4f8f-4534-9394-703261e2390b"),
                            Visit = 1
                        },
                        new
                        {
                            ID = new Guid("7297d64f-7912-4e46-a663-e543af0102fb"),
                            EndTime = new DateTime(22, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            SymptomId = new Guid("10cbac3c-2dbf-45c9-8832-e6d2dd0b2168"),
                            Visit = 1
                        },
                        new
                        {
                            ID = new Guid("a0d287bc-73e8-41b6-88f1-e7385ea7da7d"),
                            EndTime = new DateTime(2023, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            SymptomId = new Guid("10cbac3c-2dbf-45c9-8832-e6d2dd0b2168"),
                            Visit = 1
                        },
                        new
                        {
                            ID = new Guid("e822435f-5110-465f-a276-c89ee9a5dc54"),
                            EndTime = new DateTime(2023, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 3,
                            SymptomId = new Guid("e0d9efd5-c988-4692-aafd-c0096b0093ff"),
                            Visit = 1
                        },
                        new
                        {
                            ID = new Guid("c7d431a6-579b-4841-8629-2bbcb79a5e15"),
                            EndTime = new DateTime(2023, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            SymptomId = new Guid("b7862274-66a6-4ed1-a193-d1f014fe5ff9"),
                            Visit = 0
                        },
                        new
                        {
                            ID = new Guid("20f20659-d4e3-466e-b2df-e6a6b1f62fab"),
                            EndTime = new DateTime(2022, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2022, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 0,
                            SymptomId = new Guid("89fa12ed-89c5-4535-ae64-7544221ac48e"),
                            Visit = 0
                        },
                        new
                        {
                            ID = new Guid("861c579e-bb80-4dea-b8f2-4b189cb6a362"),
                            EndTime = new DateTime(2022, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2022, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 1,
                            SymptomId = new Guid("b7892990-94dd-44b8-a7cb-d142cd10e3d8"),
                            Visit = 1
                        },
                        new
                        {
                            ID = new Guid("2222ed0f-aaea-45f3-8a72-f0ee3ed23a22"),
                            EndTime = new DateTime(2022, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            PatientID = new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"),
                            PurposeId = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            StartTime = new DateTime(2022, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            Status = 3,
                            SymptomId = new Guid("b7892990-94dd-44b8-a7cb-d142cd10e3d8"),
                            Visit = 1
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.ConsultationRecord", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("AppointmentID")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("PatientID")
                        .HasColumnType("char(36)");

                    b.HasKey("ID");

                    b.HasIndex("AppointmentID");

                    b.HasIndex("PatientID");

                    b.ToTable("ConsultationRecords");
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Finding", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ConsultationRecordID")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("FName")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ConsultationRecordID");

                    b.ToTable("Findings");

                    b.HasData(
                        new
                        {
                            ID = new Guid("efd1381a-4c3d-4260-aaf2-04a0a26591bc"),
                            Description = "",
                            FName = "age-related macular degeneration"
                        },
                        new
                        {
                            ID = new Guid("672a4093-269e-47aa-879c-738cf2bf5e55"),
                            Description = "",
                            FName = "cataract"
                        },
                        new
                        {
                            ID = new Guid("332d1fb4-35f1-48d8-ac19-f66472fce607"),
                            Description = "",
                            FName = "diabetic"
                        },
                        new
                        {
                            ID = new Guid("629d1da5-bf42-4dd5-9eda-614ba1260f03"),
                            Description = "",
                            FName = "retinopathy"
                        },
                        new
                        {
                            ID = new Guid("ab7f6ecf-7e82-4281-b90d-69f4ef72b66a"),
                            Description = "",
                            FName = "glaucoma"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Patient", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            ID = new Guid("2b792220-f333-49ec-abe2-3a6fc4edb0c2"),
                            Address = "Luakan,Dinalupihan, Bataan",
                            BirthDate = new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Luisa Katrina",
                            Gender = 0,
                            LastName = "Reyes",
                            MiddleName = "Pangilinan"
                        },
                        new
                        {
                            ID = new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"),
                            Address = "Luakan,Dinalupihan, Bataan",
                            BirthDate = new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Clarissa Joy",
                            Gender = 0,
                            LastName = "Flores",
                            MiddleName = "Gozon"
                        },
                        new
                        {
                            ID = new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"),
                            Address = "Bacong,Hermosa, Bataan",
                            BirthDate = new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Raniel",
                            Gender = 1,
                            LastName = "David",
                            MiddleName = "Mallari"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Prescription", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ConsultationRecordID")
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("GName")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.HasIndex("ConsultationRecordID");

                    b.ToTable("Prescriptions");

                    b.HasData(
                        new
                        {
                            ID = new Guid("3d588288-29d3-4f29-a6e4-45734f748986"),
                            Description = "",
                            GName = "Azelastine eye drops for allergies (Optilast)"
                        },
                        new
                        {
                            ID = new Guid("71bd251b-43a1-4f19-a750-fc04e5e74876"),
                            Description = "",
                            GName = "Atropine eye drops (Minims Atropine)"
                        },
                        new
                        {
                            ID = new Guid("974e4796-cbb3-4bd8-b0a5-f5886cb10d45"),
                            Description = "",
                            GName = "Apraclonidine eye drops (Iopidine)"
                        },
                        new
                        {
                            ID = new Guid("35538073-8775-4efd-ab8a-c37479dc5109"),
                            Description = "",
                            GName = "Antazoline and xylometazoline eye drops (Otrivine-Antistin)"
                        },
                        new
                        {
                            ID = new Guid("cf144c28-7bca-4140-91bd-57983d308c1c"),
                            Description = "",
                            GName = "Aciclovir eye ointment."
                        },
                        new
                        {
                            ID = new Guid("744fa268-a8fd-4d38-a7af-239354d507b4"),
                            Description = "",
                            GName = "Acetylcysteine for dry eyes (Ilube)"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Purpose", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("PName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Purposes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"),
                            PName = " CheckUp"
                        },
                        new
                        {
                            Id = new Guid("70b4d9b7-e5bf-4da4-a355-a0af2da1d587"),
                            PName = "FollowUp"
                        },
                        new
                        {
                            Id = new Guid("912f8c3e-3ca7-4703-a858-2b9bc7612096"),
                            PName = "EyeGradeCheck"
                        },
                        new
                        {
                            Id = new Guid("3042ec44-a9b3-4bee-8a3d-14fd9f5167f7"),
                            PName = "Brokeneyeglasses"
                        },
                        new
                        {
                            Id = new Guid("9f87d3db-3842-4a4d-8552-b568c7f44620"),
                            PName = "Surgery"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Role", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Abbreviation")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            ID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"),
                            Abbreviation = "Pt",
                            Description = "One who receives medical treatment",
                            Name = "patient"
                        },
                        new
                        {
                            ID = new Guid("54f00f70-72b8-4d34-a953-83321ff6b101"),
                            Abbreviation = "Adm",
                            Description = "One who manages the system",
                            Name = "admin"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Symptom", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("SName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Symptoms");

                    b.HasData(
                        new
                        {
                            Id = new Guid("32d18f17-4f8f-4534-9394-703261e2390b"),
                            SName = "Blurred, clouded or dim vision."
                        },
                        new
                        {
                            Id = new Guid("10cbac3c-2dbf-45c9-8832-e6d2dd0b2168"),
                            SName = "Problem seeing at night."
                        },
                        new
                        {
                            Id = new Guid("0bd555b4-5d90-4033-abd7-2b19dfce9f41"),
                            SName = "Problem seeing through light and glare"
                        },
                        new
                        {
                            Id = new Guid("e0d9efd5-c988-4692-aafd-c0096b0093ff"),
                            SName = "Seeing 'halos' around lights."
                        },
                        new
                        {
                            Id = new Guid("8f908b6a-618f-486f-9aa3-ecac26ddd539"),
                            SName = "Frequently changing contact lens"
                        },
                        new
                        {
                            Id = new Guid("6e880219-f4fa-4743-bcfd-295fcd602ce3"),
                            SName = "Prescription or eyeglasses"
                        },
                        new
                        {
                            Id = new Guid("b7862274-66a6-4ed1-a193-d1f014fe5ff9"),
                            SName = "Faded view of colors"
                        },
                        new
                        {
                            Id = new Guid("03e03141-ccd4-4d5c-a7d5-2c739c4e8c2a"),
                            SName = "Faded view of colors"
                        },
                        new
                        {
                            Id = new Guid("89fa12ed-89c5-4535-ae64-7544221ac48e"),
                            SName = "Cataracts"
                        },
                        new
                        {
                            Id = new Guid("b7892990-94dd-44b8-a7cb-d142cd10e3d8"),
                            SName = "Dry Eyes"
                        },
                        new
                        {
                            Id = new Guid("b9e8ceda-2511-4f71-9c57-70bf77e128a0"),
                            SName = " Eye Pain"
                        },
                        new
                        {
                            Id = new Guid("cd2345d7-aba2-4228-9303-b647f6d70574"),
                            SName = "excessive tearing"
                        },
                        new
                        {
                            Id = new Guid("dac8c2aa-2a57-40ef-ae4c-9316a3e27d1a"),
                            SName = "burning"
                        },
                        new
                        {
                            Id = new Guid("4807111d-782b-4099-b24a-9d50cdb1093f"),
                            SName = "swollen"
                        },
                        new
                        {
                            Id = new Guid("1b89eb12-b4ae-4a4e-af4a-68a8d5f9f998"),
                            SName = "greasy or drooping eyelids"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.User", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("MiddleName")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("PatientID")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("char(36)");

                    b.HasKey("ID");

                    b.HasIndex("PatientID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            ID = new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"),
                            Address = "Dinalupihan, Orani, Bataan",
                            BirthDate = new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "luisa@yahoo.com",
                            FirstName = "Luisa Katrina",
                            Gender = 0,
                            LastName = "Pangilinan",
                            MiddleName = "Reyes",
                            PatientID = new Guid("2b792220-f333-49ec-abe2-3a6fc4edb0c2"),
                            RoleID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a")
                        },
                        new
                        {
                            ID = new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"),
                            Address = "Dinalupihan, Orani, Bataan",
                            BirthDate = new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "joy@yahoo.com",
                            FirstName = "Clarissa Joy",
                            Gender = 1,
                            LastName = "Gozon",
                            MiddleName = "Flores",
                            PatientID = new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"),
                            RoleID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a")
                        },
                        new
                        {
                            ID = new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"),
                            Address = "Dinalupihan, Orani, Bataan",
                            BirthDate = new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "renieldavid@yahoo.com",
                            FirstName = "Reniel",
                            Gender = 1,
                            LastName = "Mallari",
                            MiddleName = "David",
                            PatientID = new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"),
                            RoleID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a")
                        },
                        new
                        {
                            ID = new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"),
                            Address = "Dinalupihan, Orani , Bataan",
                            BirthDate = new DateTime(2002, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@yahoo.com",
                            FirstName = "admin",
                            Gender = 0,
                            LastName = "admin",
                            MiddleName = "admin",
                            RoleID = new Guid("54f00f70-72b8-4d34-a953-83321ff6b101")
                        },
                        new
                        {
                            ID = new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"),
                            Address = "Dinalupihan, Orani , Bataan",
                            BirthDate = new DateTime(2002, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Janedavid@yahoo.com",
                            FirstName = "Jane",
                            Gender = 0,
                            LastName = "David",
                            MiddleName = "Adan",
                            RoleID = new Guid("54f00f70-72b8-4d34-a953-83321ff6b101")
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.UserLogin", b =>
                {
                    b.Property<Guid?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Key")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("char(36)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("UserLogins");

                    b.HasData(
                        new
                        {
                            ID = new Guid("df9b7c3f-175a-4d4b-ab33-7892d5b98d35"),
                            Key = "Password",
                            Type = "General",
                            UserID = new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"),
                            Value = "$2a$11$J7yu.w0pMQA1u0zQ6CKbuOzJpcaXs56igXPnhNaUDAyTfEX6WTM4S"
                        },
                        new
                        {
                            ID = new Guid("1fbd3e7d-be71-478d-8f9a-e4a6d2a1ece7"),
                            Key = "IsActive",
                            Type = "General",
                            UserID = new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"),
                            Value = "true"
                        },
                        new
                        {
                            ID = new Guid("705e9206-9a0c-4330-bd28-5eb732565fd1"),
                            Key = "LoginRetries",
                            Type = "General",
                            UserID = new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"),
                            Value = "0"
                        },
                        new
                        {
                            ID = new Guid("bcb69dc1-a2b9-4941-ade6-a5a0d817d723"),
                            Key = "Password",
                            Type = "General",
                            UserID = new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"),
                            Value = "$2a$11$oGYI56oYvcujSv/h49/7ZuhqZoO2uOqp9OQxZXxwgCl20rn1YH1o6"
                        },
                        new
                        {
                            ID = new Guid("f43cb74e-04a5-4111-9527-ea154f391190"),
                            Key = "IsActive",
                            Type = "General",
                            UserID = new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"),
                            Value = "true"
                        },
                        new
                        {
                            ID = new Guid("ce4f70e9-2877-4692-bd2e-59416cb0f08f"),
                            Key = "LoginRetries",
                            Type = "General",
                            UserID = new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"),
                            Value = "0"
                        },
                        new
                        {
                            ID = new Guid("43e33aff-7744-4247-99d8-e7f3ebc6fff3"),
                            Key = "Password",
                            Type = "General",
                            UserID = new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"),
                            Value = "$2a$11$bYeKewUs9vj1VAJDx4bqNu7h2EI0KXz9PoG3dO3ux6JidaAjCV9ya"
                        },
                        new
                        {
                            ID = new Guid("ff461a0e-5af5-45eb-8ff6-4fa1d01559f4"),
                            Key = "IsActive",
                            Type = "General",
                            UserID = new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"),
                            Value = "true"
                        },
                        new
                        {
                            ID = new Guid("924079a4-b91f-427a-a2b6-35d82663d2e0"),
                            Key = "LoginRetries",
                            Type = "General",
                            UserID = new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"),
                            Value = "0"
                        },
                        new
                        {
                            ID = new Guid("6164f5d6-94a2-4cde-ae75-ad2cfaa508d7"),
                            Key = "Password",
                            Type = "General",
                            UserID = new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"),
                            Value = "$2a$11$1SpG5DCYYTBYQatK.lwAK.2xrvEDdgxHL63NtnYc3vfyOJnAegSzK"
                        },
                        new
                        {
                            ID = new Guid("e1d61bed-2de5-4758-b8f0-dfe9e91c49a9"),
                            Key = "IsActive",
                            Type = "General",
                            UserID = new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"),
                            Value = "true"
                        },
                        new
                        {
                            ID = new Guid("cec1b28d-443a-42d9-9144-90401ddaa1cf"),
                            Key = "LoginRetries",
                            Type = "General",
                            UserID = new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"),
                            Value = "0"
                        },
                        new
                        {
                            ID = new Guid("e56f65a9-0f7e-4483-aa27-9285647aab8f"),
                            Key = "Password",
                            Type = "General",
                            UserID = new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"),
                            Value = "$2a$11$HcuYoIoC5JbjJ0fqpW3/H.qbTRROQgShqIHrtoz5Y3V2wF0lYgD/m"
                        },
                        new
                        {
                            ID = new Guid("df295365-75b7-437b-944a-d3e4f1c12f81"),
                            Key = "IsActive",
                            Type = "General",
                            UserID = new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"),
                            Value = "true"
                        },
                        new
                        {
                            ID = new Guid("0e062bd5-e6e9-4e4b-bb41-562caf901d7a"),
                            Key = "LoginRetries",
                            Type = "General",
                            UserID = new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"),
                            Value = "0"
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.UserRole", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("RoleID")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("UserID")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a7c4deb5-b1f9-427f-a1ae-450810ca099d"),
                            RoleID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"),
                            UserID = new Guid("0352c124-f290-4f99-b1a5-e235cafcd836")
                        },
                        new
                        {
                            Id = new Guid("0afd7fbc-e014-4e4b-9dca-a08e2e4f080c"),
                            RoleID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"),
                            UserID = new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95")
                        },
                        new
                        {
                            Id = new Guid("c95713a3-a9aa-49e0-b67b-7943fb50c614"),
                            RoleID = new Guid("54f00f70-72b8-4d34-a953-83321ff6b101"),
                            UserID = new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e")
                        },
                        new
                        {
                            Id = new Guid("4988778f-d8d8-4ed2-8588-6792cb3fbf2d"),
                            RoleID = new Guid("54f00f70-72b8-4d34-a953-83321ff6b101"),
                            UserID = new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4")
                        },
                        new
                        {
                            Id = new Guid("5cd34915-dfc6-4858-96e9-99790539f19b"),
                            RoleID = new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"),
                            UserID = new Guid("7e5e4f74-9902-43da-9974-4b2a08814398")
                        });
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Appointment", b =>
                {
                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Purpose", "Purpose")
                        .WithMany()
                        .HasForeignKey("PurposeId");

                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Symptom", "Symptom")
                        .WithMany()
                        .HasForeignKey("SymptomId");

                    b.Navigation("Patient");

                    b.Navigation("Purpose");

                    b.Navigation("Symptom");
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.ConsultationRecord", b =>
                {
                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentID");

                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.Navigation("Appointment");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Finding", b =>
                {
                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.ConsultationRecord", "Consultation")
                        .WithMany()
                        .HasForeignKey("ConsultationRecordID");

                    b.Navigation("Consultation");
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.Prescription", b =>
                {
                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.ConsultationRecord", "Consultation")
                        .WithMany()
                        .HasForeignKey("ConsultationRecordID");

                    b.Navigation("Consultation");
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.User", b =>
                {
                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientID");

                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.Navigation("Patient");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Capstonep2.Infrastructure.Domain.Models.UserRole", b =>
                {
                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.HasOne("Capstonep2.Infrastructure.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
