using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using Capstonep2.Infrastructure.Domain;
using Capstonep2.Infrastructure.Domain.Models;
using Capstonep2.ViewModel;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace Capstonep2.Pages.Manage.Consultation
{
    [Authorize(Roles = "admin")]
    public class ViewDetailsModel : PageModel
    {
        private ILogger<System.Index> _logger;
        private DefaultDBContext _context;

        [BindProperty]
        public ViewModel View { get; set; }

        public ViewDetailsModel(DefaultDBContext context, ILogger<System.Index> logger)
        {
            _logger = logger;
            _context = context;
            View = View ?? new ViewModel();
        }
        public void OnGet(Guid? id = null, Guid? crid = null)

        {
            ViewData["id"] = id;
            var appointment = _context?.Appointments?.Where(a => a.ID == id).FirstOrDefault();
            var patient = _context?.Patients?.Where(a => a.ID == id).FirstOrDefault();
            if (patient != null)
            {


                ViewData["address"] = patient.Address;
                ViewData["birthdate"] = patient.BirthDate.ToString("dd/MM/yyyy");
                ViewData["firstname"] = patient.FirstName;
                ViewData["middlename"] = patient.MiddleName;
                ViewData["lastname"] = patient.LastName;
                ViewData["gender"] = patient.Gender;



                var apptsRecords = _context.Appointments?.Where(a => a.PatientID == id).ToList();
                View.Appointments = apptsRecords;


                var consultations = _context?.ConsultationRecords?.ToList();
                View.ConsultationRecords = consultations;

                var findings = _context?.Findings?.ToList();
                var prescriptions = _context?.Prescriptions?.ToList();

                View.Findings = findings;
                View.Prescriptions = prescriptions;




            }

        }
        public void OnPost()
        {

        }

        [HttpGet("dahilan")]
        public JsonResult? OnGetPurposeedit(int pageIndex = 1, string? keyword = "", int pageSize = 10)
        {
            return new JsonResult(_context.Purposes!.Select(a => new LookupDto.Result()
            {
                Id = a.Id.ToString(),
                Text = a.PName ?? ""
            })
            .AsQueryable()
            .GetLookupPaged(pageIndex, pageSize));
        }

        [HttpGet("sintomas")]
        public JsonResult? OnGetSymptomedit(int pageIndex = 1, string? keyword = "", int pageSize = 10)
        {
            return new JsonResult(_context.Symptoms!.Select(a => new LookupDto.Result()
            {
                Id = a.Id.ToString(),
                Text = a.SName ?? ""
            })
            .AsQueryable()
            .GetLookupPaged(pageIndex, pageSize));
        }
        [HttpGet("gamot")]
        public JsonResult? OnGetGamot(int pageIndex = 1, string? keyword = "", int pageSize = 10)
        {
            return new JsonResult(_context.Prescriptions!.Select(a => new LookupDto.Result()
            {
                Id = a.ID.ToString(),
                Text = a.GName ?? ""


            })
            .AsQueryable()
            .GetLookupPaged(pageIndex, pageSize));
        }

        [HttpGet("finding")]
        public JsonResult? OnGetFinding(int pageIndex = 1, string? keyword = "", int pageSize = 10)
        {
            return new JsonResult(_context.Findings!.Select(a => new LookupDto.Result()
            {
                Id = a.ID.ToString(),
                Text = a.FName ?? ""


            })
            .AsQueryable()
            .GetLookupPaged(pageIndex, pageSize));
        }
        public class ViewModel : CRViewModel
        {
            public List<Prescription>? Gamot { get; set; }
            public List<Prescription>? Prescriptions { get; set; }
            public List<Finding>? Findings { get; set; }
            public List<Symptom>? Sintomas { get; set; }
            public List<Purpose>? Dahilan { get; set; }
            public List<Appointment>? Appointments { get; set; }
            public List<Infrastructure.Domain.Models.Patient>? Patients { get; set; }
            public string? AppointmentId { get; set; }
            public List<ConsultationRecord>? ConsultationRecords { get; set; }
        }
    }

}
