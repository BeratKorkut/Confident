using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class KonutAdv
    {
        [Key]
        public int KonutID { get; set; }
        public int BrütM2 { get; set; }
        public int NetM2 { get; set; }
        public string? OdaSayısı { get; set; }
        public int BinaYasi { get; set; }
        public int KatSayisi { get; set; }
        public string? Isıtma { get; set; }
        public int BanyoSayisi { get; set; }
        public bool EsyaliMi { get; set; }
        public bool KullanımDurumu { get; set; }
        public bool SiteIciMi { get; set; }
        public string? SiteAdi { get; set; }
        public int Aidat { get; set; }
        public bool KrediyeUygunMu { get; set; }
        public bool TapuDurumu { get; set; }
        public bool Takas { get; set; }
        public string? IslendiMi { get; set; }//satıldı veya kiralandı gibi
    }
}
