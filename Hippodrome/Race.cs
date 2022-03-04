using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippodrome
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        [InverseProperty("Race")]
        public virtual List<Participation> Participations { get; set; }

    }
}
