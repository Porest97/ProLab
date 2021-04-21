using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class NBSPost
    {
        [Key]
        public int Id { get; set; }

        //Logs props !
        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        [Display(Name = "Användare")]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Användare")]
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser PostingUser { get; set; }

        public NBSPost()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        //Planning props !
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Display(Name = "Plan. Start")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePlanedStart { get; set; }

        [Display(Name = "Plan. Slut")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePlanedEnd { get; set; }

        [Display(Name = "Plan. Tim")]
        public double PlanedTime { get; set; }

        //Accual Real loged props !
        [Display(Name = "Start")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeStarted { get; set; }

        [Display(Name = "Slut")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeEnded { get; set; }

        [Display(Name = "Tim")]
        public double AccualTime { get; set; }

        [Display(Name = "Utfall")]
        public double OutCome { get; set; }

        [Display(Name = "Anstäld")]
        public string EmloyeeId { get; set; }
        [Display(Name = "Anställd")]
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
    }
}
