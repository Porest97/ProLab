using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.Models.DataModels
{
    public class TeamRoster
    {
        public int Id { get; set; }

        //HockeyGame Logning !
        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimeChanged { get; set; }

        public TeamRoster()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name = "Team")]
        public string TeamName { get; set; }

        [Display(Name = "Club")]
        public int? ClubId { get; set; }
        [Display(Name = "Club")]
        [ForeignKey("ClubId")]
        public Club Team { get; set; }

        //Coaches
        public string HeadCoach { get; set; }

        public string AssCoach { get; set; }

        //TeamLeader
        public string TeamLeader { get; set; }

        //Players        
        //#1
        [Display(Name = "Player1")]
        public int? HockeyPlayerId { get; set; }
        [Display(Name = "Player1")]
        [ForeignKey("HockeyPlayerId")]
        public HockeyPlayer Player1 { get; set; }
        
        //#2
        [Display(Name = "Player2")]
        public int? HockeyPlayerId1 { get; set; }
        [Display(Name = "Player2")]
        [ForeignKey("HockeyPlayerId1")]
        public HockeyPlayer Player2 { get; set; }
        
        //#3
        [Display(Name = "Player3")]
        public int? HockeyPlayerId2 { get; set; }
        [Display(Name = "Player3")]
        [ForeignKey("HockeyPlayerId2")]
        public HockeyPlayer Player3 { get; set; }
        
        //#4
        [Display(Name = "Player4")]
        public int? HockeyPlayerId3 { get; set; }
        [Display(Name = "Player4")]
        [ForeignKey("HockeyPlayerId3")]
        public HockeyPlayer Player4 { get; set; }
        
        //#5
        [Display(Name = "Player5")]
        public int? HockeyPlayerId4 { get; set; }
        [Display(Name = "Player5")]
        [ForeignKey("HockeyPlayerId4")]
        public HockeyPlayer Player5 { get; set; }
        
        //#6
        [Display(Name = "Player6")]
        public int? HockeyPlayerId5 { get; set; }
        [Display(Name = "Player6")]
        [ForeignKey("HockeyPlayerId5")]
        public HockeyPlayer Player6 { get; set; }
        
        //#7
        [Display(Name = "Player7")]
        public int? HockeyPlayerId6 { get; set; }
        [Display(Name = "Player7")]
        [ForeignKey("HockeyPlayerId6")]
        public HockeyPlayer Player7 { get; set; }

        //#8
        [Display(Name = "Player8")]
        public int? HockeyPlayerId7 { get; set; }
        [Display(Name = "Player8")]
        [ForeignKey("HockeyPlayerId7")]
        public HockeyPlayer Player8 { get; set; }

        //#9
        [Display(Name = "Player9")]
        public int? HockeyPlayerId8 { get; set; }
        [Display(Name = "Player9")]
        [ForeignKey("HockeyPlayerId8")]
        public HockeyPlayer Player9 { get; set; }

        //#10
        [Display(Name = "Player10")]
        public int? HockeyPlayerId9 { get; set; }
        [Display(Name = "Player10")]
        [ForeignKey("HockeyPlayerId9")]
        public HockeyPlayer Player10 { get; set; }

        //#11
        [Display(Name = "Player11")]
        public int? HockeyPlayerId10 { get; set; }
        [Display(Name = "Player11")]
        [ForeignKey("HockeyPlayerId10")]
        public HockeyPlayer Player11 { get; set; }

        //#12
        [Display(Name = "Player12")]
        public int? HockeyPlayerId11 { get; set; }
        [Display(Name = "Player12")]
        [ForeignKey("HockeyPlayerId11")]
        public HockeyPlayer Player12 { get; set; }

        //#13
        [Display(Name = "Player13")]
        public int? HockeyPlayerId12 { get; set; }
        [Display(Name = "Player13")]
        [ForeignKey("HockeyPlayerId12")]
        public HockeyPlayer Player13 { get; set; }

        //#14
        [Display(Name = "Player14")]
        public int? HockeyPlayerId13 { get; set; }
        [Display(Name = "Player14")]
        [ForeignKey("HockeyPlayerId13")]
        public HockeyPlayer Player14 { get; set; }

        //#15
        [Display(Name = "Player15")]
        public int? HockeyPlayerId14 { get; set; }
        [Display(Name = "Player15")]
        [ForeignKey("HockeyPlayerId14")]
        public HockeyPlayer Player15 { get; set; }

        //#16
        [Display(Name = "Player16")]
        public int? HockeyPlayerId15 { get; set; }
        [Display(Name = "Player16")]
        [ForeignKey("HockeyPlayerId15")]
        public HockeyPlayer Player16 { get; set; }

        //#17
        [Display(Name = "Player17")]
        public int? HockeyPlayerId16 { get; set; }
        [Display(Name = "Player17")]
        [ForeignKey("HockeyPlayerId16")]
        public HockeyPlayer Player17 { get; set; }

        //#18
        [Display(Name = "Player18")]
        public int? HockeyPlayerId17 { get; set; }
        [Display(Name = "Player18")]
        [ForeignKey("HockeyPlayerId17")]
        public HockeyPlayer Player18 { get; set; }

        //#19
        [Display(Name = "Player19")]
        public int? HockeyPlayerId18 { get; set; }
        [Display(Name = "Player19")]
        [ForeignKey("HockeyPlayerId18")]
        public HockeyPlayer Player19 { get; set; }

        //#20
        [Display(Name = "Player20")]
        public int? HockeyPlayerId19 { get; set; }
        [Display(Name = "Player20")]
        [ForeignKey("HockeyPlayerId19")]
        public HockeyPlayer Player20 { get; set; }

        //#21
        [Display(Name = "Player21")]
        public int? HockeyPlayerId20 { get; set; }
        [Display(Name = "Player21")]
        [ForeignKey("HockeyPlayerId20")]
        public HockeyPlayer Player21 { get; set; }

        //#22
        [Display(Name = "Player22")]
        public int? HockeyPlayerId21 { get; set; }
        [Display(Name = "Player22")]
        [ForeignKey("HockeyPlayerId21")]
        public HockeyPlayer Player22 { get; set; }
    }
}
