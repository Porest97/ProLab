using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.TheOneApp.Models.DataModels
{
    public class FoodRating
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public FoodRating()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name = "NR:")]
        public string FoodRatingNumber { get; set; }

        [Display(Name = "Namn")]
        public string FoodRatingName { get; set; }

        [Display(Name = "Beskrivning")]
        public string FoodRatingDescription { get; set; }
    }
}
