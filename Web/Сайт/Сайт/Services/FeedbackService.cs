using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Сайт.Services
{
    public class FeedbackService
    {
        protected inetmagazContext dB;
        public FeedbackService()
        {
        }
        //GetIzdelie_spr
        public bool InsertFeedback(Feedback feedback)
        {
            using (dB = new inetmagazContext())
            {
                dB.Feedbacks.Add(feedback);
                dB.SaveChanges();
                return true;
            }
        }
    }
}
