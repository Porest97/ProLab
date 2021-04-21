using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class HockeyGame
    {

        public int Id { get; set; }

        //HockeyGame Logning !
        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimeChanged { get; set; }

        public HockeyGame()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }


        //Game DateTime Prop !
        [Display(Name = "Datum & Tid")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime GameDateTime { get; set; }

        // Game Identification Prop!
        [Display(Name = "Match #")]
        public string GameNumber { get; set; }

        // Game TSM Idenfication Prop !
        [Display(Name = "TSM #")]
        public string TSMNumber { get; set; }

        // Game settings props !
        [Display(Name = "Kategori")]
        public int? GameCategoryId { get; set; }
        [Display(Name = "Kategori")]
        [ForeignKey("GameCategoryId")]
        public GameCategory GameCategory { get; set; }

        [Display(Name = "Status")]
        public int? GameStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("GameStatusId")]
        public GameStatus GameStatus { get; set; }

        [Display(Name = "Match Type")]
        public int? GameTypeId { get; set; }
        [Display(Name = "Match Type")]
        [ForeignKey("GameTypeId")]
        public GameType GameType { get; set; }

        [Display(Name = "Serie")]
        public int? SeriesId { get; set; }
        [Display(Name = "Serie")]
        [ForeignKey("SeriesId")]
        public Series Series { get; set; }

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
        public string GameTeams { get { return string.Format("{0} {1} {2}", HomeTeam, "-", AwayTeam); } }



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

    }

    public class Club
    {
        public int Id { get; set; }

        // Club props !
        [Display(Name = "#")]
        public string ClubNumber { get; set; }

        [Display(Name = "Klubb")]
        public string ClubName { get; set; }
    }

    public class Arena
    {
        public int Id { get; set; }

        [Display(Name = "#")]
        public string ArenaNumber { get; set; }

        [Display(Name = "Arena")]
        public string ArenaName { get; set; }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }
    }

    public class Series
    {
        public int Id { get; set; }


        [Display(Name = "Number")]
        public string SeriesNumber { get; set; }

        [Display(Name = "Serie")]
        public string SeriesName { get; set; }

        [Display(Name = "Speltid")]
        public string SeriesPlayTime { get; set; }



    }

    public class GameType
    {
        public int Id { get; set; }

        [Display(Name = "Typ")]
        public string GameTypeName { get; set; }
    }

    public class GameStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string GameStatusName { get; set; }
    }

    public class GameCategory
    {
        public int Id { get; set; }

        [Display(Name = "Kategori")]
        public string GameCategoryName { get; set; }
    }
}
