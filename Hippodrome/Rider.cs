using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hippodrome
{
    public class Rider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String FullName { get; set; }
        public int Age { get; set; }
    }
}
