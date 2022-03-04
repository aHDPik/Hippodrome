using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippodrome
{
    public class Participation
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int RiderHorseId { get; set; }
        [ForeignKey("RaceId")]
        public virtual Race Race { get; set; }
        [ForeignKey("RiderHorseId")]
        public virtual RiderHorse RiderHorse { get; set; }
        public int? Place { get; set; }
    }
}
