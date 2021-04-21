using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class CleverServicePayments
    {
        public int Id { get; set; }
        [Display(Name = "Match Datum")]
        [DataType(DataType.Date)]
        public DateTime? GameDate { get; set; }
        [Display(Name = "Betal Datum")]
        [DataType(DataType.Date)]
        public DateTime? PaymentDate { get; set; }

        [Display(Name = "Beskrivning")]        
        public string Description { get; set; }
        
        [Display(Name = "Förening")]
        public int? ClubId { get; set; }
        [Display(Name = "Förening")]
        [ForeignKey("ClubId")]
        public Club Club { get; set; }

        public decimal PaymentBeforeTax { get; set; }

        public decimal Tax { get; set; }

        public decimal Payment { get; set; }

        [Display(Name = "Status")]
        public int? CSPStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("CSPStatusId")]
        public CSPStatus CSPStatus { get; set; }


    }

    public class CSPStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string CSPStatusName { get; set; }
    }
}
