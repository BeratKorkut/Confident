using Microsoft.AspNetCore.Mvc.Rendering;

namespace Confident.Areas.Member.Models
{
    public class IlanSatilikKiralik
    {
        public List<SelectListItem> GetIlanSatilikKiralikList()
        {
            String[] SatilikKiralikArray = { "Satılık", "Kiralık" };
            new List<string>(SatilikKiralikArray);//arrayi liste çevirme


            List<SelectListItem> ilanSatilikKiralik = (from x in SatilikKiralikArray
                                            select new SelectListItem
                                            {
                                                Text = x,
                                                Value = x
                                            }).ToList();
            return ilanSatilikKiralik;
        }
    }
}
