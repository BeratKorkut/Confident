using Microsoft.AspNetCore.Mvc.Rendering;

namespace Confident.Areas.Member.Models
{
    public class IlanTip
    {
        public List<SelectListItem> GetIlanTipList()
        {
            String[] TipArray = { "Konut","İş Yeri","Arsa","Bina" };
            new List<string>(TipArray);//arrayi liste çevirme
            

            List<SelectListItem> ilanTip = (from x in TipArray
                                           select new SelectListItem
                                           {
                                               Text = x,
                                               Value = x
                                           }).ToList();
            return ilanTip;
        }
    }
}
