using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Detail
    {
        [Key]
        public int DetayID { get; set; }
        public string? Cephe { get; set; }
        public string? IcOzellik { get; set; }
        public string? DisOzellik { get; set; }
        public string? Muhit { get; set; }
        public string? Ulasim { get; set; }
        public string? Manzara { get; set; }
        public string? KonutTipi { get; set; }
    }
}
