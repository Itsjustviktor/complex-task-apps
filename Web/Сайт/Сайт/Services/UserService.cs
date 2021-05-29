using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сайт.Services
{
    public class UserService
    {
        protected inetmagazContext dB;
        public UserService()
        {
        }

        public bool InsertUser(Buyer buyer)
        {
            using (dB = new inetmagazContext())
            {
                dB.Buyers.Add(buyer);
                dB.SaveChanges();
                return true;
            }
        } //добавление

        public List<Buyer> GetBuyer()
        {
            using (dB = new inetmagazContext())
            {
                return dB.Buyers.ToList();
            }
        }

    }


}
