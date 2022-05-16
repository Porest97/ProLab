using ProLab.Models.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Hockey4Life.Models.DataModels
{
    public class Hockey4LifeLog
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

        public Hockey4LifeLog()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name ="Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Events { get; set; }

        public int HockeyDay { get; set; }

        public int DayInLife { get; set; }

        public decimal Hours { get; set; }

        public int NumberOfGames { get; set; }

        //Ref
        public int? RefereeId { get; set; }
        [Display(Name = "Ref")]
        [ForeignKey("RefereeId")]
        public Referee Ref { get; set; }        

        //HockeyGames
        public int? GameId { get; set; }
        [Display(Name = "Game1")]
        [ForeignKey("GameId")]
        public Game Game1 { get; set; }

        public int? GameId1 { get; set; }
        [Display(Name = "Game2")]
        [ForeignKey("GameId1")]
        public Game Game2 { get; set; }

        public int? GameId2 { get; set; }
        [Display(Name = "Game3")]
        [ForeignKey("GameId2")]
        public Game Game3 { get; set; }

        public int? GameId3 { get; set; }
        [Display(Name = "Game4")]
        [ForeignKey("GameId3")]
        public Game Game4 { get; set; }

        public int? GameId4 { get; set; }
        [Display(Name = "Game5")]
        [ForeignKey("GameId4")]
        public Game Game5 { get; set; }

        public int? GameId5 { get; set; }
        [Display(Name = "Game6")]
        [ForeignKey("GameId5")]
        public Game Game6 { get; set; }

        public int? GameId6 { get; set; }
        [Display(Name = "Game7")]
        [ForeignKey("GameId6")]
        public Game Game7 { get; set; }

        public int? GameId7 { get; set; }
        [Display(Name = "Game8")]
        [ForeignKey("GameId7")]
        public Game Game8 { get; set; }

        public int? GameId8 { get; set; }
        [Display(Name = "Game9")]
        [ForeignKey("GameId8")]
        public Game Game9 { get; set; }

        public int? GameId9 { get; set; }
        [Display(Name = "Game10")]
        [ForeignKey("GameId9")]
        public Game Game10 { get; set; }


    }
}
