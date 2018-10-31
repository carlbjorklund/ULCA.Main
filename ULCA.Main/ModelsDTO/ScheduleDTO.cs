using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ULCA.Main.ModelsDTO
{
    public class ScheduleDTO
    {
        [Key]
        public int ScheduledId { get; set; }
        public string Image { get; set; }

        [ForeignKey("Channel")]
        public int ChannelId { get; set; }
        public ChannelDTO Channel { get; set; }

        public DateTime AirDate { get; set; }
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan LengthTimeSpan { get; set; }

        [ForeignKey("Show")]
        public int ShowId { get; set; }
        public List<ShowDTO> Shows { get; set; }
    }
}
