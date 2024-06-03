using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(double monthlyFee, int minSubPeriod, List<string> channels) : base(monthlyFee, minSubPeriod, channels) { }
    }
}
