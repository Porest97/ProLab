using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.Models.DataModels
{
    public class HockeyPlayer
    {
        public int Id { get; set; }

        [Display(Name = "First name")]
        public string FirstName { get; set; }
        [Display(Name = "Last name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName { get { return string.Format("{0} {1} {2}", FirstName," ", LastName); } }

        [Display(Name = "SSN")]
        public string SSN { get; set; }

        [Display(Name = "Age")]
        public string Age { get; set; }

        [Display(Name = "Pos.")]
        public int? PlayerTypeId { get; set; }
        [Display(Name = "Pos.")]
        [ForeignKey("PlayerTypeId")]
        public PlayerType PlayerType { get; set; }


    }

    public class PlayerType
    {
        public int? Id { get; set; }

        [Display(Name = "Player Type.")]
        public string PlayerTypeName { get; set; }

        [Display(Name = "Pos.")]
        public string PlayerTypeShortName { get; set; }
    }
}
