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
        public string? Tip { get; set; }
        public string? KiralikSatilik { get; set; }
        public string? TipDetay { get; set; }

    }
}
