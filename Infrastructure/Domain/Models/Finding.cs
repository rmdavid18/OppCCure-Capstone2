﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Capstonep2.Infrastructure.Domain.Models
{
    public class Finding
    {
        public Guid? ID { get; set; }
        public string? FName { get; set; }
        public string? Description { get; set; }
        public Guid? ConsultationRecordID { get; set; }

        [ForeignKey("ConsultationRecordID")]
        public ConsultationRecord? Consultation { get; set; }
    }
}
