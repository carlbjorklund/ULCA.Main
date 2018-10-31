using System.ComponentModel.DataAnnotations;

namespace ULCA.Main.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CatImage { get; set; }


    }
}