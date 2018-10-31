using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ULCA.Main.Models
{
    public class Show
    {
        [Key]
        public int SchowId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Length { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}