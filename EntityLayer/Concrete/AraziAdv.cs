using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AraziAdv
    {
        [Key]
        public int ArazıID { get; set; }
        public string? ImarDurumu { get; set; } //İmar Durumu
        public decimal m2 { get; set; } //kaç metrekare
        public int m2Price { get; set; } //metrekaresi kaç tl
        public int AdaNo { get; set; } 
        public int ParselNo { get; set; } 
        public int PaftaNo { get; set; } 
        public decimal Kaks { get; set; } 
        public decimal Gabari { get; set; } //bir yapının kaldırım hizasından çatıya kadar olan maksimum yüksekliğini ifade eder
        public string? TapuDurumu { get; set; }
        public bool KatKarsiligi { get; set; }
        public bool KrediyeUygunluk { get; set; }
        public bool Takas { get; set; }
    }
}
