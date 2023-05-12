using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Capstonep2.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MiddleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Purposes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purposes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abbreviation = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Symptoms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    SName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Symptoms", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Type = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Key = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PatientID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MiddleName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RoleID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    StartTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    PatientID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Visit = table.Column<int>(type: "int", nullable: false),
                    SymptomId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    PurposeId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Appointments_Purposes_PurposeId",
                        column: x => x.PurposeId,
                        principalTable: "Purposes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    UserID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    RoleID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConsultationRecords",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PatientID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    AppointmentID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultationRecords", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ConsultationRecords_Appointments_AppointmentID",
                        column: x => x.AppointmentID,
                        principalTable: "Appointments",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ConsultationRecords_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Findings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    FName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConsultationRecordID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Findings", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Findings_ConsultationRecords_ConsultationRecordID",
                        column: x => x.ConsultationRecordID,
                        principalTable: "ConsultationRecords",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    GName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConsultationRecordID = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Prescriptions_ConsultationRecords_ConsultationRecordID",
                        column: x => x.ConsultationRecordID,
                        principalTable: "ConsultationRecords",
                        principalColumn: "ID");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Findings",
                columns: new[] { "ID", "ConsultationRecordID", "Description", "FName" },
                values: new object[,]
                {
                    { new Guid("332d1fb4-35f1-48d8-ac19-f66472fce607"), null, "", "diabetic" },
                    { new Guid("629d1da5-bf42-4dd5-9eda-614ba1260f03"), null, "", "retinopathy" },
                    { new Guid("672a4093-269e-47aa-879c-738cf2bf5e55"), null, "", "cataract" },
                    { new Guid("ab7f6ecf-7e82-4281-b90d-69f4ef72b66a"), null, "", "glaucoma" },
                    { new Guid("efd1381a-4c3d-4260-aaf2-04a0a26591bc"), null, "", "age-related macular degeneration" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "ID", "Address", "BirthDate", "FirstName", "Gender", "LastName", "MiddleName" },
                values: new object[,]
                {
                    { new Guid("2b792220-f333-49ec-abe2-3a6fc4edb0c2"), "Luakan,Dinalupihan, Bataan", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Luisa Katrina", 0, "Reyes", "Pangilinan" },
                    { new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"), "Luakan,Dinalupihan, Bataan", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clarissa Joy", 0, "Flores", "Gozon" },
                    { new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"), "Bacong,Hermosa, Bataan", new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raniel", 1, "David", "Mallari" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "ID", "ConsultationRecordID", "Description", "GName" },
                values: new object[,]
                {
                    { new Guid("35538073-8775-4efd-ab8a-c37479dc5109"), null, "", "Antazoline and xylometazoline eye drops (Otrivine-Antistin)" },
                    { new Guid("3d588288-29d3-4f29-a6e4-45734f748986"), null, "", "Azelastine eye drops for allergies (Optilast)" },
                    { new Guid("71bd251b-43a1-4f19-a750-fc04e5e74876"), null, "", "Atropine eye drops (Minims Atropine)" },
                    { new Guid("744fa268-a8fd-4d38-a7af-239354d507b4"), null, "", "Acetylcysteine for dry eyes (Ilube)" },
                    { new Guid("974e4796-cbb3-4bd8-b0a5-f5886cb10d45"), null, "", "Apraclonidine eye drops (Iopidine)" },
                    { new Guid("cf144c28-7bca-4140-91bd-57983d308c1c"), null, "", "Aciclovir eye ointment." }
                });

            migrationBuilder.InsertData(
                table: "Purposes",
                columns: new[] { "Id", "PName" },
                values: new object[,]
                {
                    { new Guid("3042ec44-a9b3-4bee-8a3d-14fd9f5167f7"), "Brokeneyeglasses" },
                    { new Guid("70b4d9b7-e5bf-4da4-a355-a0af2da1d587"), "FollowUp" },
                    { new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), " CheckUp" },
                    { new Guid("912f8c3e-3ca7-4703-a858-2b9bc7612096"), "EyeGradeCheck" },
                    { new Guid("9f87d3db-3842-4a4d-8552-b568c7f44620"), "Surgery" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "Abbreviation", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"), "Pt", "One who receives medical treatment", "patient" },
                    { new Guid("54f00f70-72b8-4d34-a953-83321ff6b101"), "Adm", "One who manages the system", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Symptoms",
                columns: new[] { "Id", "SName" },
                values: new object[,]
                {
                    { new Guid("03e03141-ccd4-4d5c-a7d5-2c739c4e8c2a"), "Faded view of colors" },
                    { new Guid("0bd555b4-5d90-4033-abd7-2b19dfce9f41"), "Problem seeing through light and glare" },
                    { new Guid("10cbac3c-2dbf-45c9-8832-e6d2dd0b2168"), "Problem seeing at night." },
                    { new Guid("1b89eb12-b4ae-4a4e-af4a-68a8d5f9f998"), "greasy or drooping eyelids" },
                    { new Guid("32d18f17-4f8f-4534-9394-703261e2390b"), "Blurred, clouded or dim vision." },
                    { new Guid("4807111d-782b-4099-b24a-9d50cdb1093f"), "swollen" },
                    { new Guid("6e880219-f4fa-4743-bcfd-295fcd602ce3"), "Prescription or eyeglasses" },
                    { new Guid("89fa12ed-89c5-4535-ae64-7544221ac48e"), "Cataracts" },
                    { new Guid("8f908b6a-618f-486f-9aa3-ecac26ddd539"), "Frequently changing contact lens" },
                    { new Guid("b7862274-66a6-4ed1-a193-d1f014fe5ff9"), "Faded view of colors" },
                    { new Guid("b7892990-94dd-44b8-a7cb-d142cd10e3d8"), "Dry Eyes" },
                    { new Guid("b9e8ceda-2511-4f71-9c57-70bf77e128a0"), " Eye Pain" },
                    { new Guid("cd2345d7-aba2-4228-9303-b647f6d70574"), "excessive tearing" },
                    { new Guid("dac8c2aa-2a57-40ef-ae4c-9316a3e27d1a"), "burning" },
                    { new Guid("e0d9efd5-c988-4692-aafd-c0096b0093ff"), "Seeing 'halos' around lights." }
                });

            migrationBuilder.InsertData(
                table: "UserLogins",
                columns: new[] { "ID", "Key", "Type", "UserID", "Value" },
                values: new object[,]
                {
                    { new Guid("0e062bd5-e6e9-4e4b-bb41-562caf901d7a"), "LoginRetries", "General", new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"), "0" },
                    { new Guid("1fbd3e7d-be71-478d-8f9a-e4a6d2a1ece7"), "IsActive", "General", new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"), "true" },
                    { new Guid("43e33aff-7744-4247-99d8-e7f3ebc6fff3"), "Password", "General", new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"), "$2a$11$bYeKewUs9vj1VAJDx4bqNu7h2EI0KXz9PoG3dO3ux6JidaAjCV9ya" },
                    { new Guid("6164f5d6-94a2-4cde-ae75-ad2cfaa508d7"), "Password", "General", new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"), "$2a$11$1SpG5DCYYTBYQatK.lwAK.2xrvEDdgxHL63NtnYc3vfyOJnAegSzK" },
                    { new Guid("705e9206-9a0c-4330-bd28-5eb732565fd1"), "LoginRetries", "General", new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"), "0" },
                    { new Guid("924079a4-b91f-427a-a2b6-35d82663d2e0"), "LoginRetries", "General", new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"), "0" },
                    { new Guid("bcb69dc1-a2b9-4941-ade6-a5a0d817d723"), "Password", "General", new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"), "$2a$11$oGYI56oYvcujSv/h49/7ZuhqZoO2uOqp9OQxZXxwgCl20rn1YH1o6" },
                    { new Guid("ce4f70e9-2877-4692-bd2e-59416cb0f08f"), "LoginRetries", "General", new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"), "0" },
                    { new Guid("cec1b28d-443a-42d9-9144-90401ddaa1cf"), "LoginRetries", "General", new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"), "0" },
                    { new Guid("df295365-75b7-437b-944a-d3e4f1c12f81"), "IsActive", "General", new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"), "true" },
                    { new Guid("df9b7c3f-175a-4d4b-ab33-7892d5b98d35"), "Password", "General", new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"), "$2a$11$J7yu.w0pMQA1u0zQ6CKbuOzJpcaXs56igXPnhNaUDAyTfEX6WTM4S" },
                    { new Guid("e1d61bed-2de5-4758-b8f0-dfe9e91c49a9"), "IsActive", "General", new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"), "true" },
                    { new Guid("e56f65a9-0f7e-4483-aa27-9285647aab8f"), "Password", "General", new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"), "$2a$11$HcuYoIoC5JbjJ0fqpW3/H.qbTRROQgShqIHrtoz5Y3V2wF0lYgD/m" },
                    { new Guid("f43cb74e-04a5-4111-9527-ea154f391190"), "IsActive", "General", new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"), "true" },
                    { new Guid("ff461a0e-5af5-45eb-8ff6-4fa1d01559f4"), "IsActive", "General", new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"), "true" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "ID", "EndTime", "PatientID", "PurposeId", "StartTime", "Status", "SymptomId", "Visit" },
                values: new object[,]
                {
                    { new Guid("20f20659-d4e3-466e-b2df-e6a6b1f62fab"), new DateTime(2022, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2022, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("89fa12ed-89c5-4535-ae64-7544221ac48e"), 0 },
                    { new Guid("2222ed0f-aaea-45f3-8a72-f0ee3ed23a22"), new DateTime(2022, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2022, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 3, new Guid("b7892990-94dd-44b8-a7cb-d142cd10e3d8"), 1 },
                    { new Guid("3ce371f9-dc79-4623-b84f-0b2fe7c99962"), new DateTime(2023, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("32d18f17-4f8f-4534-9394-703261e2390b"), 1 },
                    { new Guid("7297d64f-7912-4e46-a663-e543af0102fb"), new DateTime(22, 2, 23, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, new Guid("10cbac3c-2dbf-45c9-8832-e6d2dd0b2168"), 1 },
                    { new Guid("861c579e-bb80-4dea-b8f2-4b189cb6a362"), new DateTime(2022, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2022, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 1, new Guid("b7892990-94dd-44b8-a7cb-d142cd10e3d8"), 1 },
                    { new Guid("a0d287bc-73e8-41b6-88f1-e7385ea7da7d"), new DateTime(2023, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("10cbac3c-2dbf-45c9-8832-e6d2dd0b2168"), 1 },
                    { new Guid("c7d431a6-579b-4841-8629-2bbcb79a5e15"), new DateTime(2023, 2, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("b7862274-66a6-4ed1-a193-d1f014fe5ff9"), 0 },
                    { new Guid("e822435f-5110-465f-a276-c89ee9a5dc54"), new DateTime(2023, 2, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"), new Guid("7f28dca4-e0f4-4798-a823-f44cdcd2a3b0"), new DateTime(2023, 2, 12, 11, 30, 0, 0, DateTimeKind.Unspecified), 3, new Guid("e0d9efd5-c988-4692-aafd-c0096b0093ff"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "BirthDate", "Email", "FirstName", "Gender", "LastName", "MiddleName", "PatientID", "RoleID" },
                values: new object[,]
                {
                    { new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4"), "Dinalupihan, Orani , Bataan", new DateTime(2002, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Janedavid@yahoo.com", "Jane", 0, "David", "Adan", null, new Guid("54f00f70-72b8-4d34-a953-83321ff6b101") },
                    { new Guid("0352c124-f290-4f99-b1a5-e235cafcd836"), "Dinalupihan, Orani, Bataan", new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "luisa@yahoo.com", "Luisa Katrina", 0, "Pangilinan", "Reyes", new Guid("2b792220-f333-49ec-abe2-3a6fc4edb0c2"), new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a") },
                    { new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e"), "Dinalupihan, Orani , Bataan", new DateTime(2002, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@yahoo.com", "admin", 0, "admin", "admin", null, new Guid("54f00f70-72b8-4d34-a953-83321ff6b101") },
                    { new Guid("7e5e4f74-9902-43da-9974-4b2a08814398"), "Dinalupihan, Orani, Bataan", new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "renieldavid@yahoo.com", "Reniel", 1, "Mallari", "David", new Guid("8664a4bd-0ec6-4aaa-83e6-7d2bd0315b5a"), new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a") },
                    { new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95"), "Dinalupihan, Orani, Bataan", new DateTime(2001, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "joy@yahoo.com", "Clarissa Joy", 1, "Gozon", "Flores", new Guid("5a7e7bc3-8816-41df-b44d-eeb60ae99b5b"), new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a") }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleID", "UserID" },
                values: new object[,]
                {
                    { new Guid("0afd7fbc-e014-4e4b-9dca-a08e2e4f080c"), new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"), new Guid("d7dbd16f-1c71-4415-a147-22a2b428bf95") },
                    { new Guid("4988778f-d8d8-4ed2-8588-6792cb3fbf2d"), new Guid("54f00f70-72b8-4d34-a953-83321ff6b101"), new Guid("00acfb7f-6c90-459a-b53f-bf73ddac85b4") },
                    { new Guid("5cd34915-dfc6-4858-96e9-99790539f19b"), new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"), new Guid("7e5e4f74-9902-43da-9974-4b2a08814398") },
                    { new Guid("a7c4deb5-b1f9-427f-a1ae-450810ca099d"), new Guid("2afa881f-e519-4e67-a841-e4a2630e8a2a"), new Guid("0352c124-f290-4f99-b1a5-e235cafcd836") },
                    { new Guid("c95713a3-a9aa-49e0-b67b-7943fb50c614"), new Guid("54f00f70-72b8-4d34-a953-83321ff6b101"), new Guid("1bd5f519-b891-4491-9a7c-a86cd0c2a15e") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientID",
                table: "Appointments",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PurposeId",
                table: "Appointments",
                column: "PurposeId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_SymptomId",
                table: "Appointments",
                column: "SymptomId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRecords_AppointmentID",
                table: "ConsultationRecords",
                column: "AppointmentID");

            migrationBuilder.CreateIndex(
                name: "IX_ConsultationRecords_PatientID",
                table: "ConsultationRecords",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Findings_ConsultationRecordID",
                table: "Findings",
                column: "ConsultationRecordID");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_ConsultationRecordID",
                table: "Prescriptions",
                column: "ConsultationRecordID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserID",
                table: "UserRoles",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PatientID",
                table: "Users",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Findings");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "ConsultationRecords");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Purposes");

            migrationBuilder.DropTable(
                name: "Symptoms");
        }
    }
}
