using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class PlanPost
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public PlanPost()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;           
        }

        [Display(Name = "Användare")]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Användare")]
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        
        [Display(Name = "Datum/Tid Planerad")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime? PlanedDateTime { get; set; }

        [Display(Name = "Datum/Tid Startad")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime? StartDateTime { get; set; }

        [Display(Name = "Datum/Tid Avslutad")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime? EndDateTime { get; set; }

        [Display(Name = "Aktivitet")]
        public int AktivitetId { get; set; }
        [Display(Name = "Aktivitet")]
        [ForeignKey("AktivitetId")]
        public Aktivitet Aktivitet { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }
    }

    public class Aktivitet
    {
        public int Id { get; set; }

        [Display(Name = "Aktivitet")]
        public string AktivitetsBeskrivning { get; set; }
    }
}
