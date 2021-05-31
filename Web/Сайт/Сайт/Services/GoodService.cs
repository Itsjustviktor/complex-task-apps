using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сайт.Services
{
    public class GoodService
    {
        protected inetmagazContext dB;
        public GoodService()
        {
        }
        //GetIzdelie_spr
        public List<Good> GetGoods()
        {
            using (dB = new inetmagazContext())
            {
                return dB.Goods.ToList();
            }
        } //возвращает лист гудс

        public bool UpdateGood(Good good, int count)
        {
            using (dB = new inetmagazContext())
            {
                var updategood = dB.Goods.FirstOrDefault(u => u.Idgood == good.Idgood);
                if(updategood.Quantity-count<0)
                {
                    throw new Exception("На складе недостаточно товара");
                }
                else
                {
                    updategood.Quantity = updategood.Quantity - count;
                    dB.SaveChanges();
                    return true;
                }
            }
        } //возвращает лист гудс
    }
}
