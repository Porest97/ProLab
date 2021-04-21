using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.Models.DataModels
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        //Logs props !
        [Display(Name = "Skapad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimePosted { get; set; }

        [Display(Name = "Ändrad")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime DateTimeChanged { get; set; }

        [Display(Name = "Användare")]
        public string ApplicationUserId { get; set; }
        [Display(Name = "Användare")]
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser User { get; set; }

        public Employee()
        {
            DateTimePosted = DateTime.Now;
            DateTimeChanged = DateTime.Now;                      
        }

        [Display(Name = "Anställnings NR")]
        public string EmployeeNumber { get; set; }

        [Display(Name = "Namn")]
        public string Name { get; set; }

        [Display(Name = "Adress")]
        public string Address { get; set; }

        [Display(Name = "Telefon")]
        public string PhoneNumbers { get; set; }

    }
}