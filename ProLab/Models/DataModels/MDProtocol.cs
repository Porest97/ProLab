using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class MDProtocol
    {
        public int Id { get; set; }

        [Display(Name = "Namn")]
        public int? RefereeId { get; set; }
        [Display(Name = "Namn")]
        [ForeignKey("RefereeId")]
        public Referee Referee { get; set; }

        [Display(Name = "Datum & Tidpunkt")]
        public DateTime Date { get; set; }

        [Display(Name = "Kroppstemperatur")]
        public string BodyTemp { get; set; }

        [Display(Name = "Halsont")]
        public string SoreThroat { get; set; }

        [Display(Name = "Snuva")]
        public string NasalCongestion { get; set; }

        [Display(Name = "Hosta")]
        public string Cough { get; set; }

        [Display(Name = "Huvudvärk")]
        public string Headache { get; set; }

        [Display(Name = "Illamående")]
        public string Nausea { get; set; }

        [Display(Name = "Diarré")]
        public string Diarrhea { get; set; }

        [Display(Name = "Muskelvärk *")]
        public string MuscleAches { get; set; }

        [Display(Name = "Symtom")]
        public string OtherSymptoms { get; set; }

        [Display(Name = "I så fall beskriv symtomen")]
        public string OtherSymptomsDescription { get; set; }

        [Display(Name = "Uppvisar någon annan närstående symtom")]
        public string FamilySymtoms { get; set; }
    }
}
