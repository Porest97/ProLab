using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProLab.Models.DataModels
{
    public class UploadModel
    {
        [Key]
        public int UploadId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Item Name")]
        public string UploadName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile UploadFile { get; set; }
    }
}
