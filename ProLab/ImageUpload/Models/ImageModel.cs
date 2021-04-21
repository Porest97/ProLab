using Microsoft.AspNetCore.Http;
using ProLab.Models.DataModels;
using ProLab.ImageUpload.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.ImageUpload.Models
{
    public class ImageModel
    {
        [Key]
        public int ImageId { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        public string Title { get; set;  }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        [Display(Name = "TSM #")]
        public int? HockeyGameId { get; set; }
        [Display(Name = "TSM #")]
        [ForeignKey("HockeyGameId")]
        public HockeyGame HockeyGame { get; set; }

    }
}
