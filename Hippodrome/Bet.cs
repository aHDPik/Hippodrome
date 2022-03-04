using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippodrome
{
    public class Bet
    {
        public int Id { get; set; }
        public int ParticipationId { get; set; }
        public int CustomerId { get; set; }
        public double Amount { get; set; }
        [ForeignKey("ParticipationId")]
        public virtual Participation Participation { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

    }
}
