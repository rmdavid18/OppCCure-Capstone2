using System.ComponentModel.DataAnnotations.Schema;

namespace Capstonep2.Infrastructure.Domain.Models
{
    public class Appointment
    {
        public Guid? ID { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        
        
        public Guid? PatientID { get; set; }
        public Enums.Status Status { get; set; }
        public Enums.Visit Visit { get; set; }


        public Guid? SymptomId { get; set; }
        public Guid? PurposeId { get; set; }

        [ForeignKey("SymptomId")]
        public Symptom? Symptom { get; set; }

        [ForeignKey("PurposeId")]
        public Purpose? Purpose { get; set; }
        [ForeignKey("PatientID")]
        public Patient? Patient { get; set; }

    }
}