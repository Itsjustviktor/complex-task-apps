using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сайт.Services
{
    public class OrderService
    {
        protected inetmagazContext dB;
        public OrderService()
        {
        }

        public bool InsertOrder(Order order)
        {
            using (dB = new inetmagazContext())
            {
                dB.Orders.Add(order);
                dB.SaveChanges();
                return true;
            }
        }
        public bool InsertOrderedGood(Orderedgood orderedgood)
        {
            using (dB = new inetmagazContext())
            {
                dB.Orderedgoods.Add(orderedgood);
                
                    dB.SaveChanges();
                
                return true;
            }
        }

    }
}
