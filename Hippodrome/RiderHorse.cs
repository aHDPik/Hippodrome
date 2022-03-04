using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippodrome
{
    public class RiderHorse
    {
        [Key]
        public int Id { get; set; }
        public String RiderFullName { get; set; }
        public string HorseNumber { get; set; }
        [ForeignKey("RiderFullName")]
        public virtual Rider Rider { get; set; }
        [ForeignKey("HorseNumber")]
        public virtual Horse Horse { get; set; }
    }
}
