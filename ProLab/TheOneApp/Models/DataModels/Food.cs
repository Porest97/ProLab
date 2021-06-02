using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.TheOneApp.Models.DataModels
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public Food()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }


        //Food values !
        [Display(Name = "Namn")]
        public string FoodName { get; set; }

        [Display(Name = "Nummer")]
        public string FoodNumber { get; set; }

        [Display(Name = "Gruppering")]
        public string FoodDescription { get; set; }

        [Display(Name = "Kcal (100g)")]
        public decimal EnergyKcal { get; set; }

        [Display(Name = "KJ (100g)")]
        public decimal EnergyKJ { get; set; }

        [Display(Name = "Kolhydrater (g)")]
        public decimal Carbohydrates { get; set; }

        [Display(Name = "Fett (g)")]
        public decimal Fat { get; set; }

        [Display(Name = "Protein (100g)")]
        public decimal Protein { get; set; }

        [Display(Name = "Fibrer (g)")]
        public decimal Fibers { get; set; }

        [Display(Name = "Vatten (g)")]
        public decimal Water { get; set; }

        [Display(Name = "Alcohol (g)")]
        public decimal Alcohol { get; set; }

        [Display(Name = "Ash (g)")]
        public decimal Ash { get; set; }

        [Display(Name = "Monosaccharides (g)")]
        public decimal Monosaccharides { get; set; }

        [Display(Name = "Disaccharides (g)")]
        public decimal Disaccharides { get; set; }

        [Display(Name = "Sucrose (g)")]
        public decimal Sucrose { get; set; }

        [Display(Name = "WholeGrainsTotal (g)")]
        public decimal WholeGrainsTotal { get; set; }

        [Display(Name = "Sugars (g)")]
        public decimal Sugars { get; set; }

        [Display(Name = "TotalSaturatedFattyAcids (g)")]
        public decimal TotalSaturatedFattyAcids { get; set; }

        [Display(Name = "FattyAcid40100(g)")]
        public decimal FattyAcid40100 { get; set; }

        [Display(Name = "LauricAcidC120 (g)")]
        public decimal LauricAcidC120 { get; set; }

        [Display(Name = "MyristicAcidC140 (g)")]
        public decimal MyristicAcidC140 { get; set; }

        [Display(Name = "PalmiticAcidC160 (g)")]
        public decimal PalmiticAcidC160 { get; set; }

        [Display(Name = "StearinAcid180 (g)")]
        public decimal StearinAcid180 { get; set; }

        [Display(Name = "ArachidicAcidC200  (g)")]
        public decimal ArachidicAcidC200 { get; set; }

        [Display(Name = "TotalMonounsaturatedFattyAcids (g)")]
        public decimal TotalMonounsaturatedFattyAcids { get; set; }

        [Display(Name = "PalmOleicAcidC161 (g)")]
        public decimal PalmOleicAcidC161 { get; set; }

        [Display(Name = "OleicAcidC181 (g)")]
        public decimal OleicAcidC181 { get; set; }

        [Display(Name = "TotalPolyunsaturatedFattyAcids  (g)")]
        public decimal TotalPolyunsaturatedFattyAcids { get; set; }

        [Display(Name = "LinoleAcidC182 (g)")]
        public decimal LinoleAcidC182 { get; set; }

        [Display(Name = "LinolenicAcidC183 (g)")]
        public decimal LinolenicAcidC183 { get; set; }

        [Display(Name = "ArachidonicAcidC204 (g)")]
        public decimal ArachidonicAcidC204 { get; set; }

        [Display(Name = "EPAC205 (g)")]
        public decimal EPAC205 { get; set; }

        [Display(Name = "DPAC225 (g)")]
        public decimal DPAC225 { get; set; }

        [Display(Name = "DHAC226 (g)")]
        public decimal DHAC226 { get; set; }

        [Display(Name = "Cholesterol (g)")]
        public decimal Cholesterol { get; set; }

        [Display(Name = "Retinol (g)")]
        public decimal Retinol { get; set; }

        [Display(Name = "VitaminA (g)")]
        public decimal VitaminA { get; set; }

        [Display(Name = "BetaCarotene (g)")]
        public decimal BetaCarotene { get; set; }

        [Display(Name = "VitaminD (g)")]
        public decimal VitaminD { get; set; }

        [Display(Name = "VitaminE (g)")]
        public decimal VitaminE { get; set; }

        [Display(Name = "VitaminK (g)")]
        public decimal VitaminK { get; set; }

        [Display(Name = "Thiamine(g)")]
        public decimal Thiamine { get; set; }

        [Display(Name = "Riboflavin (g)")]
        public decimal Riboflavin { get; set; }

        [Display(Name = "VitaminC (g)")]
        public decimal VitaminC { get; set; }

        [Display(Name = "Niacin (g)")]
        public decimal Niacin { get; set; }

        [Display(Name = "NiacinEquivalents (g)")]
        public decimal NiacinEquivalents { get; set; }

        [Display(Name = "VitaminB6 (g)")]
        public decimal VitaminB6 { get; set; }

        [Display(Name = "VitaminB12 (g)")]
        public decimal VitaminB12 { get; set; }

        [Display(Name = "Folate (g)")]
        public decimal Folate { get; set; }

        [Display(Name = "Phosphorus (g)")]
        public decimal Phosphorus { get; set; }

        [Display(Name = "Iodine (g)")]
        public decimal Iodine { get; set; }

        [Display(Name = "Iron (g)")]
        public decimal Iron { get; set; }

        [Display(Name = "Calcium (g)")]
        public decimal Calcium { get; set; }

        [Display(Name = "Potassium (g)")]
        public decimal Potassium { get; set; }

        [Display(Name = "Magnesium (g)")]
        public decimal Magnesium { get; set; }

        [Display(Name = "Sodium (g)")]
        public decimal Sodium { get; set; }

        [Display(Name = "Salt (g)")]
        public decimal Salt { get; set; }

        [Display(Name = "Selenium (g)")]
        public decimal Selenium { get; set; }

        [Display(Name = "Zink (g)")]
        public decimal Zink { get; set; }

        [Display(Name = "WasteProcent (%)")]
        public decimal WasteProcent { get; set; }

    }
}
