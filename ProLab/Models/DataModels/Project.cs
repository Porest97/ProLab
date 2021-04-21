using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.Models.DataModels
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimeChanged { get; set; }

        public Project()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name = "Projekt #")]
        public string ProjektNumber { get; set; }

        [Display(Name = "Projekt")]
        public string ProjectName { get; set; }

        [Display(Name = "Plats")]
        public string Location { get; set; }

        [Display(Name = "Start.Plan")]
        public DateTime PlanedStart { get; set; }

        [Display(Name = "Slut.Plan")]
        public DateTime PlanedEnd { get; set; }

        [Display(Name = "Startat")]
        public DateTime Started { get; set; }

        [Display(Name = "Avslutat")]
        public DateTime Ended { get; set; }

        [Display(Name = "Budget (Tim)")]
        public Double BudgetHours { get; set; }

        [Display(Name = "Anv. (Tim)")]
        public Double UsedHours { get; set; }

        [Display(Name = "Utfall")]
        public Double Outcome { get; set; }

        [Display(Name = "Status")]
        public int ProjectStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("ProjectStatusId")]
        public ProjectPostStatus Status { get; set; }
    }
    public class ProjectStatus
    {
        [Key]
        public int Id { get; set; }

        public string ProjectStatusName { get; set; }
    }

}