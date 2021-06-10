using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class FoodDiaryPost
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        [Display(Name = "Användare")]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Avändare")]
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }




        public FoodDiaryPost()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }


        [Display(Name = "Datum & Tid")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime DateTime { get; set; }

        //Food Props
        public string Meal { get; set; }

        public decimal Calories { get; set; }

        public decimal Fat { get; set; }

        public decimal SaturatedFat { get; set; }

        public decimal PolyunsaturatedFat { get; set; }

        public decimal MonounsaturatedFat { get; set; }

        public decimal TransFat { get; set; }

        public decimal Cholesterol { get; set; }

        public decimal Sodium { get; set; }

        public decimal Potassium { get; set; }

        public decimal Carbohydrates { get; set; }

        public decimal Fibers { get; set; }

        public decimal Sugar { get; set; }

        public decimal Protein { get; set; }

        public decimal VitaminA { get; set; }

        public decimal VitaminC { get; set; }

        public decimal Calcium { get; set; }

        public decimal Iron { get; set; }

        public string Notes { get; set; }

    }
}
