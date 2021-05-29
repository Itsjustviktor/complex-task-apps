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
    }
}
