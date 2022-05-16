using System;
using System.ComponentModel.DataAnnotations;

namespace ProLab.Models.DataModels
{
    public class HockeyStats
    {
        public int Id { get; set; }

        //HockeyGame Logning !
        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimeChanged { get; set; }

        public HockeyStats()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }


        //Game DateTime Prop !
        [Display(Name = "Datum & Tid")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime? GameDateTime { get; set; }

        [Display(Name = "Matchnr")]
        public string MatchNumber { get; set; }

        [Display(Name = "Hemmalag")]
        public string HomeTeam { get; set; }

        [Display(Name = "Bortalag")]
        public string AwayTeam { get; set; }

        [Display(Name = "Arena")]
        public string Arena { get; set; }

        [Display(Name = "Serie")]
        public string Series { get; set; }

        [Display(Name = "HD")]
        public string HD1 { get; set; }

        [Display(Name = "HD")]
        public string HD2 { get; set; }

        [Display(Name = "LD")]
        public string LD1 { get; set; }

        [Display(Name = "LD")]
        public string LD2 { get; set; }

        [Display(Name = "Supervisor")]
        public string Supervisor { get; set; }

        [Display(Name = "Notering")]
        public string Notes { get; set; }

        [Display(Name = "Arvode")]
        public decimal? TotalPayments { get; set; }

        // Game Result Props !
        [Display(Name = "Mål Hemma")]
        public int? HomeTeamScore { get; set; }

        [Display(Name = "Mål Borta")]
        public int? AwayTeamScore { get; set; }

        [Display(Name = "Resultat")]
        public string Result { get { return string.Format("{0} {1} {2}", HomeTeamScore, "-", AwayTeamScore); } }

        //[Display(Name = "Hemma - Borta")]
        public string GameTeams { get { return string.Format("{0} {1} {2}", HomeTeam, "-", AwayTeam); } }

        [Display(Name ="Match")]
        public bool IsMatch { get; set; }
        
        
        [Display(Name = "Träning")]
        public bool IsPractise { get; set; }


        [Display(Name = "MatchRef")]
        public bool IsMatchRef { get; set; }


    }
}
