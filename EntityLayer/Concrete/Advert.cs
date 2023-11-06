using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Advert //Advert-İlan
    {
        [Key]
        public int IlanID { get; set; } 
        public string? Baslik { get; set; }
        public string? Fiyat { get; set; }
        public string? Gorsel { get; set; }
        public string? Il { get; set; }
        public string? Ilce { get; set; }
        public string? Adres { get; set; }
        public string? Tanım { get; set; }
        public DateTime IlanTarih { get; set; }


    }
}
