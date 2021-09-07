using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class Penalty
    {
        public int Id { get; set; }

        public DateTime DateTimeOut { get; set; }

        public DateTime DateTimeIn { get; set; }
    }
}
