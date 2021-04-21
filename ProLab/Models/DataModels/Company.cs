using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProLab.Models.DataModels
{
    public class Company
    {
        public int Id { get; set; }

        // Company props !
        [Display(Name = "#")]
        public string CompanyNumber { get; set; }

        [Display(Name = "Namn")]
        public string CompanyName { get; set; }


        [Display(Name = "Adress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Post.NR")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "Ort")]
        public string City { get; set; }

        [Display(Name = "Land")]
        public string Country { get; set; }

        [Display(Name = "Adress")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }


        //Company Settings
        public int? CompanyRoleId { get; set; }
        [Display(Name = "Roll")]
        [ForeignKey("CompanyRoleId")]
        public CompanyRole CompanyRole { get; set; }

        public int? CompanyStatusId { get; set; }
        [Display(Name = "Status")]
        [ForeignKey("CompanyStatusId")]
        public CompanyStatus CompanyStatus { get; set; }

        public int? CompanyTypeId { get; set; }
        [Display(Name = "Typ")]
        [ForeignKey("CompanyTypeId")]
        public CompanyType CompanyType { get; set; }
    }

    //Role, Status And Type
    public class CompanyRole
    {
        public int Id { get; set; }

        [Display(Name = "Roll")]
        public string CompanyRoleName { get; set; }

    }

    public class CompanyStatus
    {
        public int Id { get; set; }

        [Display(Name = "Status")]
        public string CompanyStatusName { get; set; }

    }

    public class CompanyType
    {
        public int Id { get; set; }

        [Display(Name = "Typ")]
        public string CompanyTypeName { get; set; }
    }
}
