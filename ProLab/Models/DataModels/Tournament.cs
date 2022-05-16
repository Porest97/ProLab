using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class Tournament
    {
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public Tournament()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name = "Start")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime StartDateTime { get; set; }

        [Display(Name = "End")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime EndDateTime { get; set; }
        

        [Display(Name = "Category")]
        public int? TournamentCategoryId { get; set; }
        [Display(Name = "Category")]
        [ForeignKey("TournamentCategoryId")]
        public TournamentCategory TournamentCategory { get; set; }

        [Display(Name = "Name")]
        public string TournamentName { get; set; }

    }

    public class TournamentCategory
    {
        public int Id { get; set; }

        [Display(Name = "Category")]
        public string TournamentCategoryName { get; set; }

        [Display(Name = "Category Decription")]
        public string TournamentCategoryDescription { get; set; }
    }
}
