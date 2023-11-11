using Microsoft.AspNetCore.Mvc.Rendering;

namespace Confident.Areas.Member.Models
{
    public class IlanTipDetay
    {
        public List<SelectListItem> GetIlanTipDetayList()
        {
            String[] TipDetayArray = { "Daire", "Residence","Müstakil Ev","Villa","Köşk","Yazlık","Prefabrik Ev","---------","Büro","Cafe","İş Hanı","Ofis","---------","Arsa","-------- - ","Bina" };
            new List<string>(TipDetayArray);//arrayi liste çevirme


            List<SelectListItem> ilanTipDetay = (from x in TipDetayArray
                                                       select new SelectListItem
                                                       {
                                                           Text = x,
                                                           Value = x
                                                       }).ToList();
            return ilanTipDetay;
        }
    }
}
