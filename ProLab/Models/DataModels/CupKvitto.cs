using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.Models.DataModels
{
    public class CupKvitto
    {
        public int Id { get; set; }

        //CupKvitto Logning !
        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTimeChanged { get; set; }

        public CupKvitto()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;
        }

        [Display(Name = "Cup")]
        public int? TournamentId { get; set; }
        [Display(Name = "Cup")]
        [ForeignKey("TournamentId")]
        public Tournament Tournament { get; set; }

        [Display(Name = "Domare")]
        public int? RefereeId { get; set; }
        [Display(Name = "Domare")]
        [ForeignKey("RefereeId")]
        public Referee Referee { get; set; }

        //Games !!
        [Display(Name = "#1")]
        public int? HockeyGameId { get; set; }
        [Display(Name = "#1")]
        [ForeignKey("HockeyGameId")]
        public HockeyGame HockeyGame1 { get; set; }

        [Display(Name = "#2")]
        public int? HockeyGameId1 { get; set; }
        [Display(Name = "#2")]
        [ForeignKey("HockeyGameId1")]
        public HockeyGame HockeyGame2 { get; set; }

        [Display(Name = "#3")]
        public int? HockeyGameId2 { get; set; }
        [Display(Name = "#3")]
        [ForeignKey("HockeyGameId2")]
        public HockeyGame HockeyGame3 { get; set; }

        [Display(Name = "#4")]
        public int? HockeyGameId3 { get; set; }
        [Display(Name = "#4")]
        [ForeignKey("HockeyGameId3")]
        public HockeyGame HockeyGame4 { get; set; }

        [Display(Name = "#5")]
        public int? HockeyGameId4 { get; set; }
        [Display(Name = "#5")]
        [ForeignKey("HockeyGameId4")]
        public HockeyGame HockeyGame5 { get; set; }

        [Display(Name = "#6")]
        public int? HockeyGameId5 { get; set; }
        [Display(Name = "#6")]
        [ForeignKey("HockeyGameId5")]
        public HockeyGame HockeyGame6 { get; set; }

        [Display(Name = "#7")]
        public int? HockeyGameId6 { get; set; }
        [Display(Name = "#7")]
        [ForeignKey("HockeyGameId6")]
        public HockeyGame HockeyGame7 { get; set; }

        [Display(Name = "#8")]
        public int? HockeyGameId7 { get; set; }
        [Display(Name = "#8")]
        [ForeignKey("HockeyGameId7")]
        public HockeyGame HockeyGame8 { get; set; }

        [Display(Name = "#9")]
        public int? HockeyGameId8 { get; set; }
        [Display(Name = "#9")]
        [ForeignKey("HockeyGameId8")]
        public HockeyGame HockeyGame9 { get; set; }

        [Display(Name = "#10")]
        public int? HockeyGameId9 { get; set; }
        [Display(Name = "#10")]
        [ForeignKey("HockeyGameId9")]
        public HockeyGame HockeyGame10 { get; set; }

        [Display(Name = "#11")]
        public int? HockeyGameId10 { get; set; }
        [Display(Name = "#11")]
        [ForeignKey("HockeyGameId10")]
        public HockeyGame HockeyGame11 { get; set; }

        [Display(Name = "#12")]
        public int? HockeyGameId11 { get; set; }
        [Display(Name = "#12")]
        [ForeignKey("HockeyGameId11")]
        public HockeyGame HockeyGame12 { get; set; }

        [Display(Name = "#13")]
        public int? HockeyGameId12 { get; set; }
        [Display(Name = "#13")]
        [ForeignKey("HockeyGameId12")]
        public HockeyGame HockeyGame13 { get; set; }

        [Display(Name = "#14")]
        public int? HockeyGameId13 { get; set; }
        [Display(Name = "#14")]
        [ForeignKey("HockeyGameId13")]
        public HockeyGame HockeyGame14 { get; set; }

        [Display(Name = "#15")]
        public int? HockeyGameId14 { get; set; }
        [Display(Name = "#15")]
        [ForeignKey("HockeyGameId14")]
        public HockeyGame HockeyGame15 { get; set; }



        //Notes !
        [Display(Name = "Notering")]
        public string Notes { get; set; }

        //Status !!
        [Display(Name = "Status")]
        public int? RefRecStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("RefRecStatusId")]
        public RefRecStatus Status { get; set; }

        //Payments !!    

        [Display(Name = "Arvoden Totalt")]
        public decimal TotalFee { get; set; }

        [Display(Name = "Traktamente")]
        public decimal Allowance { get; set; }

        [Display(Name = "Resa(Km)")]
        public decimal Km { get; set; }

        [Display(Name = "Resa(kr)")]
        public decimal TravelExpenses { get; set; }

        [Display(Name = "Arbetsersättning")]
        public decimal LostErnings { get; set; }

        [Display(Name = "Reslön.")]
        public decimal TravelSalarySupplement { get; set; }

        [Display(Name = "Sen Matchstart")]
        public decimal LateGameStart { get; set; }

        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [Display(Name = "Tot.")]
        public decimal TotalCost { get; set; }

        //GameFees !
        [Display(Name = "Ers.#1")]
        public decimal GameFee1 { get; set; }

        [Display(Name = "Ers.#2")]
        public decimal GameFee2 { get; set; }

        [Display(Name = "Ers.#3")]
        public decimal GameFee3 { get; set; }

        [Display(Name = "Ers.#4")]
        public decimal GameFee4 { get; set; }

        [Display(Name = "Ers.#5")]
        public decimal GameFee5 { get; set; }

        [Display(Name = "Ers.#6")]
        public decimal GameFee6 { get; set; }

        [Display(Name = "Ers.#7")]
        public decimal GameFee7 { get; set; }

        [Display(Name = "Ers.#8")]
        public decimal GameFee8 { get; set; }

        [Display(Name = "Ers.#9")]
        public decimal GameFee9 { get; set; }

        [Display(Name = "Ers.#10")]
        public decimal GameFee10 { get; set; }

        [Display(Name = "Ers.#11")]
        public decimal GameFee11 { get; set; }

        [Display(Name = "Ers.#12")]
        public decimal GameFee12 { get; set; }

        [Display(Name = "Ers.#13")]
        public decimal GameFee13 { get; set; }

        [Display(Name = "Ers.#14")]
        public decimal GameFee14 { get; set; }

        [Display(Name = "Ers.#15")]
        public decimal GameFee15 { get; set; }

    }
}
