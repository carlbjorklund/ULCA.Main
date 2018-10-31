using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ULCA.Main.ModelsDTO
{
    public class ShowDTO
    {
        [Key]
        public int SchowId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public string ShoImage { get; set; }

        public int Length { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public CategoryDTO Category { get; set; }
    }
}