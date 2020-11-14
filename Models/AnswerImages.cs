using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab5.Models
{
    public class AnswerImages
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "ID")]
        [Required]
        [Key]
        public int AnswerImageId { get; set; }

        [Required]
        public string FileName { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }

        
    }
}
