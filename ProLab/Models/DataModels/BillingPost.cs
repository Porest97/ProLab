﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class BillingPost
    {
        public int Id { get; set; }


        [Display(Name = "Kund")]
        public string Customer { get; set; }

        [Display(Name = "Incident")]
        public string Incident { get; set; }

        [Display(Name = "Startad")]
        public DateTime? Started { get; set; }

        [Display(Name = "Avslutad")]
        public DateTime? Ended { get; set; }

        [Display(Name = "Tid")]
        public decimal Hours { get; set; }

        [Display(Name = "Tim. Pris")]
        public decimal Price { get; set; }

        [Display(Name = "Totalt")]
        public decimal Total { get; set; }

        [Display(Name = "Utlägg")]
        public decimal Outlay { get; set; }

        [Display(Name = "Ansälld")]
        public int? EmployeeId { get; set; }
        [Display(Name = "Anställd")]
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [Display(Name = "Anteckningar")]
        public string Notes { get; set; }

        [Display(Name = "WL#")]
        public string WLNumber { get; set; }

        [Display(Name = "Status")]
        public int? BPStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("BPStatusId")]
        public BPStatus BPStatus { get; set; }

        [Display(Name = "PO#")]
        public string PONumber { get; set; }

    }

    public class BPStatus
    {
        public int Id { get; set; }
        [Display(Name = "Status")]
        public string BPStatusName { get; set; }
    }
}

