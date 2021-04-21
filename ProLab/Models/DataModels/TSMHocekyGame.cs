using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class TSMHocekyGame
    {
        public int Id { get; set; }

        //Game DateTime Prop !
        [Display(Name = "Date&Time")]
        [DisplayFormat(DataFormatString = "{0:ddd yyyy-MM-dd HH:mm}")]
        public DateTime GameDateTime { get; set; }

        // Game Identification Prop!
        [Display(Name = "Game #")]
        public string GameNumber { get; set; }

        [Display(Name = "Round")]
        public string Round { get; set; }

        [Display(Name = "Home")]
        public string HomeTeam { get; set; }

        [Display(Name = "Away")]
        public string AwayTeam { get; set; }

        [Display(Name = "Arena")]
        public string Arena { get; set; }

        [Display(Name = "Series")]
        public string Series { get; set; }

        [Display(Name = "HD")]
        public string HD1 { get; set; }

        [Display(Name = "HD")]
        public string HD2 { get; set; }

        [Display(Name = "LD")]
        public string LD1 { get; set; }

        [Display(Name = "LD")]
        public string LD2 { get; set; }

        [Display(Name = "Super.")]
        public string Supervisor { get; set; }

        [Display(Name = "Changed")]
        public string DateChanged { get; set; }

        [Display(Name = "Changed By")]
        public string ChangedBy { get; set; }

        [Display(Name = "Status")]
        public int? GameStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("GameStatusId")]
        public GameStatus GameStatus { get; set; }

    }   
}
