using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class TSMGame
    {
        public int Id { get; set; }

        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        public TSMGame()
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

        // Game location prop !
        [Display(Name = "Arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }

        // Game Teams Props !
        [Display(Name = "Hemma")]
        public int? ClubId { get; set; }
        [Display(Name = "Hemma")]
        [ForeignKey("ClubId")]
        public Club HomeTeam { get; set; }

        [Display(Name = "Borta")]
        public int? ClubId1 { get; set; }
        [Display(Name = "Borta")]
        [ForeignKey("ClubId1")]
        public Club AwayTeam { get; set; }

        // Game Result Props !
        [Display(Name = "Mål Hemma")]
        public int? HomeTeamScore { get; set; }

        [Display(Name = "Mål Borta")]
        public int? AwayTeamScore { get; set; }

        [Display(Name = "Resultat")]
        public string Result { get { return string.Format("{0} {1} {2}", HomeTeamScore, "-", AwayTeamScore); } }

        //[Display(Name = "Hemma - Borta")]
        //public string Teams { get { return string.Format("{0} {1} {2}", HomeTeam.ClubName, "-", AwayTeam.ClubName); } }     



        // Game Ref props !
        [Display(Name = "HD")]
        public int? RefereeId { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("RefereeId")]
        public Referee HD1 { get; set; }

        [Display(Name = "HD")]
        public int? RefereeId1 { get; set; }
        [Display(Name = "HD")]
        [ForeignKey("RefereeId1")]
        public Referee HD2 { get; set; }

        [Display(Name = "LD")]
        public int? RefereeId2 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("RefereeId2")]
        public Referee LD1 { get; set; }

        [Display(Name = "LD")]
        public int? RefereeId3 { get; set; }
        [Display(Name = "LD")]
        [ForeignKey("RefereeId3")]
        public Referee LD2 { get; set; }

        [Display(Name = "Serie")]
        public int? TSMSeriesId { get; set; }
        [Display(Name = "Serie")]
        [ForeignKey("TSMSeriesId")]
        public TSMSeries TSMSeries { get; set; }

    }

    public class TSMSeries
    {
        public int Id { get; set; }

        [Display(Name = "Serie")]
        public string TSMSeriesName { get; set; }


    }
}
