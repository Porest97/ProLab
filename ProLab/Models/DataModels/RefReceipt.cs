using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class RefReceipt
    {
        public int Id { get; set; }

        [Display(Name = "Match")]
        public int? HockeyGameId { get; set; }
        [Display(Name = "Match")]
        [ForeignKey("HockeyGameId")]
        public HockeyGame HockeyGame { get; set; }


        //Fucking huvuddomarna !
        //HD1
        [Display(Name = "Arvode")]
        public decimal GameFeeHD1 { get; set; }
        [Display(Name = "Trakt.")]
        public decimal AllowanceHD1 { get; set; }

        [Display(Name = "Resa(Km)")]
        public decimal KmHD1 { get; set; } 

        [Display(Name = "Res.ers.")]
        public decimal TravelExpensesHD1 { get; set; }
        [Display(Name = "Arb.Ers")]
        public decimal LostErningsHD1 { get; set; }
        [Display(Name = "Reslön.")]
        public decimal TravelSalarySupplementHD1 { get; set; }
        [Display(Name = "Övrigt")]
        public decimal OtherHD1 { get; set; }
        [Display(Name = "Besk.")]
        public string DescriptionOthersHD1 { get; set; }
        [Display(Name = "Tot.")]
        public decimal TotalCostHD1 { get; set; }

        //HD2
        [Display(Name = "Arvode")]
        public decimal GameFeeHD2 { get; set; }
        [Display(Name = "Trakt.")]
        public decimal AllowanceHD2 { get; set; }

        [Display(Name = "Resa(Km)")]
        public decimal KmHD2 { get; set; }

        [Display(Name = "Res.ers.")]
        public decimal TravelExpensesHD2 { get; set; }
        [Display(Name = "Arb.Ers")]
        public decimal LostErningsHD2 { get; set; }
        [Display(Name = "Reslön.")]
        public decimal TravelSalarySupplementHD2 { get; set; }
        [Display(Name = "Övrigt")]
        public decimal OtherHD2 { get; set; }
        [Display(Name = "Besk.")]
        public string DescriptionOthersHD2 { get; set; }
        [Display(Name = "Tot.")]
        public decimal TotalCostHD2 { get; set; }

        //Fucking linjedomarna !
        //LD1
        [Display(Name = "Arvode")]
        public decimal GameFeeLD1 { get; set; }
        [Display(Name = "Trakt.")]
        public decimal AllowanceLD1 { get; set; }

        [Display(Name = "Resa(Km)")]
        public decimal KmLD1 { get; set; }

        [Display(Name = "Res.ers.")]
        public decimal TravelExpensesLD1 { get; set; }
        [Display(Name = "Arb.Ers")]
        public decimal LostErningsLD1 { get; set; }
        [Display(Name = "Reslön.")]
        public decimal TravelSalarySupplementLD1 { get; set; }
        [Display(Name = "Övrigt")]
        public decimal OtherLD1 { get; set; }
        [Display(Name = "Besk.")]
        public string DescriptionOthersLD1 { get; set; }
        [Display(Name = "Tot.")]
        public decimal TotalCostLD1 { get; set; }

        //LD2
        [Display(Name = "Arvode")]
        public decimal GameFeeLD2 { get; set; }
        [Display(Name = "Trakt.")]
        public decimal AllowanceLD2 { get; set; }

        [Display(Name = "Resa(Km)")]
        public decimal KmLD2 { get; set; }

        [Display(Name = "Res.ers.")]
        public decimal TravelExpensesLD2 { get; set; }
        [Display(Name = "Arb.Ers")]
        public decimal LostErningsLD2 { get; set; }
        [Display(Name = "Reslön.")]
        public decimal TravelSalarySupplementLD2 { get; set; }
        [Display(Name = "Övrigt")]
        public decimal OtherLD2 { get; set; }
        [Display(Name = "Besk.")]
        public string DescriptionOthersLD2 { get; set; }
        [Display(Name = "Tot.")]
        public decimal TotalCostLD2 { get; set; }

        [Display(Name = "Totalt")]
        public decimal TotalCostHockeyGame { get; set; }
        [Display(Name = "Tot.50/50")]
        public decimal TotalCostHalfHockeyGame { get; set; }

        //Fucking Status !
        [Display(Name = "Status")]
        public int? RefRecStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("RefRecStatusId")]
        public RefRecStatus RefRecStatus { get; set; }

    }

    public class RefRecStatus
    {
        public int Id { get; set; }

        public string RefRecStatusName { get; set; }
    }
}
