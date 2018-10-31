using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ULCA.Main.ModelsDTO
{
    public class ChannelDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Title { get; set; }


        public string ChaImage { get; set; }


        List<ShowDTO> Schedules { get; set; }

    }
}
