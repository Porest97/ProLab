using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class RefFees
    {
        public int Id { get; set; }
        [Display(Name = "Kategori")]
        public string Category { get; set; }
        [Display(Name ="Matchledare")]
        [DataType(DataType.Currency)]
        public decimal UDZ { get; set; }

        [Display(Name = "HD")]
        [DataType(DataType.Currency)]
        public decimal HD { get; set; }

        [Display(Name = "LD")]
        [DataType(DataType.Currency)]
        public decimal LD { get; set; }
    }
}
