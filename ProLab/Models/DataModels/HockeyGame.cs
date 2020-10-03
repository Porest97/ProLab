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

        //Game DateTime Prop !
        [Display(Name = "Date&Time")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime GameDateTime { get; set; }

        // Game Identification Prop!
        [Display(Name = "Game #")]
        public string GameNumber { get; set; }

        // Game TSM Idenfication Prop !
        [Display(Name = "TSM #")]
        public string TSMNumber { get; set; }

        // Game settings props !
        [Display(Name = "Category")]
        public int? GameCategoryId { get; set; }
        [Display(Name = "Category")]
        [ForeignKey("GameCategoryId")]
        public GameCategory GameCategory { get; set; }

        [Display(Name = "Status")]
        public int? GameStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("GameStatusId")]
        public GameStatus GameStatus { get; set; }

        [Display(Name = "Game Type")]
        public int? GameTypeId { get; set; }
        [Display(Name = "GameType")]
        [ForeignKey("GameTypeId")]
        public GameType GameType { get; set; }

        [Display(Name = "Series")]
        public int? SeriesId { get; set; }
        [Display(Name = "Series")]
        [ForeignKey("SeriesId")]
        public Series Series { get; set; }

        // Game location prop !
        [Display(Name = "Arena")]
        public int? ArenaId { get; set; }
        [Display(Name = "Arena")]
        [ForeignKey("ArenaId")]
        public Arena Arena { get; set; }

        // Game Teams Props !
        [Display(Name = "Home")]
        public int? ClubId { get; set; }
        [Display(Name = "Home")]
        [ForeignKey("ClubId")]
        public Club HomeTeam { get; set; }

        [Display(Name = "Away")]
        public int? ClubId1 { get; set; }
        [Display(Name = "Away")]
        [ForeignKey("ClubId1")]
        public Club AwayTeam { get; set; }

        // Game Result Props !
        [Display(Name = "Score Home Team")]
        public int? HomeTeamScore { get; set; }

        [Display(Name = "Score Away Team")]
        public int? AwayTeamScore { get; set; }

        [Display(Name = "Score")]
        public string Result { get { return string.Format("{0} {1} {2}", HomeTeamScore, "-", AwayTeamScore); } }

       

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

        [Display(Name = "Club")]
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

        [Display(Name = "Series")]
        public string SeriesName { get; set; }

        [Display(Name = "Game time")]
        public string SeriesPlayTime { get; set; }



    }

    public class GameType
    {
        public int Id { get; set; }

        [Display(Name = "Type")]
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

        [Display(Name = "Category")]
        public string GameCategoryName { get; set; }
    }
}
