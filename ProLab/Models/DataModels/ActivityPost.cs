using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class ActivityPost
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        [Display(Name = "Start")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeStarted { get; set; }

        [Display(Name = "Slut")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeEnded { get; set; }

        [Display(Name = "Tim")]        
        public int HoursSpent { get; set; }

        [Display(Name = "Min")]
        public int MinutesSpent { get; set; }

        [Display(Name = "Sek")]
        public int SecondsSpent { get; set; }

        [Display(Name = "Användare")]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Användare")]
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }

        [Display(Name = "Aktivitet")]
        public int HealthActivityId { get; set; }
        [Display(Name = "Aktivitet")]
        [ForeignKey("HealthActivityId")]
        public HealthActivity HealthActivity { get; set; }

        [Display(Name = "Status")]
        public int ActivityPostStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ActivityPostStatusId")]
        public ActivityPostStatus ActivityPostStatus { get; set; }

        public ActivityPost()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
            DateTimeStarted = DateTime.Now;
            DateTimeEnded = DateTime.Now;
        }
        [Display(Name = "Bskrivning")]
        public string Description { get; set; }

        [Display(Name = "Plats")]
        public string Location { get; set; }



    }

    public class HealthActivity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Aktivitet")]
        public string HealthActivityName { get; set; }

        [Display(Name = "Kcal/Tim")]
        public int KcalPerHour { get; set; }

    }

    public class ActivityPostStatus
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string ActivityPostStatusName { get; set; }
    }
}
