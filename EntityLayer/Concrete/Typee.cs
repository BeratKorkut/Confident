using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Typee
    {
        [Key]
        public int TipID { get; set; }
        public string? TipIsim { get; set; }
        public bool TipDurum { get; set; }
    }
}
