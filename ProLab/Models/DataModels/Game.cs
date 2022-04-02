using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class Game
    {
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public Game()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        //Game DateTime Prop !
        [Display(Name = "Datum & Tid")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm ddddddd}")]
        public DateTime GameDateTime { get; set; }

        // Game TSM Idenfication Prop !
        [Display(Name = "TSM #")]
        public string TSMNumber { get; set; }

        [Display(Name = "Round")]
        public string Round { get; set; }

        [Display(Name = "Home")]
        public string HomeTeam { get; set; }

        [Display(Name = "Away")]
        public string AwayTeam { get; set; }

        [Display(Name = "Arena")]
        public string Arena { get; set; }

        [Display(Name = "Series")]
        public string Series { get; set; }

        [Display(Name = "Result")]
        public string Result { get; set; }

        [Display(Name = "Audience")]
        public string Audience { get; set; }

        [Display(Name = "Information")]
        public string Information { get; set; }
    }
}
