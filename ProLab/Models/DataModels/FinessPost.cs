using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class FinessPost
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

        


        public FinessPost()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }


        [Display(Name = "Datum & Tid")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime DateTime { get; set; }

        //Food Props
        public string Meal { get; set; }

        public string Calories { get; set; }

        public string Fat { get; set; }


    }
}
