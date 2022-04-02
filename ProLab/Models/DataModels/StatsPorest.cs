using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class StatsPorest
    {
        public int Id { get; set; }

        public DateTime? EventDay { get; set; }

        public string EventDescription { get; set; }

        public int? HockeyDay { get; set; }

        public decimal? WorkoutHours { get; set; }

    }
}
