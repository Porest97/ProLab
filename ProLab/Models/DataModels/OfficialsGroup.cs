using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class OfficialsGroup
    {
        [Key]
        public int Id { get; set; }

        //Secretariat
        [Display(Name = "Sek. Grupp")]
        public string GroupName { get; set; }

        [Display(Name = "Speaker")]
        public string Speaker { get; set; }

        [Display(Name = "Klocka")]
        public string MatchClock { get; set; }

        [Display(Name = "Protokoll")]
        public string MatchProtocol { get; set; }

        [Display(Name = "Båsdörr 1")]
        public string BoothDoor1 { get; set; }

        [Display(Name = "Båsdörr 2")]
        public string BoothDoor2 { get; set; }

        [Display(Name = "Skott Stats.")]
        public string ShotStatistics { get; set; }

        [Display(Name = "Musik")]
        public string DiscJockey { get; set; }

        //Referees
        [Display(Name = "HD")]
        public string Referee1 { get; set; }

        [Display(Name = "HD")]
        public string Referee2 { get; set; }

        [Display(Name = "LD")]
        public string LinesMan1 { get; set; }

        [Display(Name = "LD")]
        public string LinesMan2 { get; set; }

        [Display(Name = "Supervisor")]
        public string Supervisor { get; set; }

    }
}
