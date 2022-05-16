using ProLab.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProLab.Models.ViewModels
{
    public class CupViewModel
    {
        public List<Tournament> Cups { get; internal set; }

        public List<HockeyGame> HockeyGames { get; internal set; }

        public List<Referee> Refs { get; internal set; } 
    }
}
