using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SubscriptionFactory
    {
        public Subscription CreateSubscription(string subscriptionType)
        {
            switch (subscriptionType.ToLower())
            {
                case "domestic":
                    return new DomesticSubscription(5, 1, new List<string> {"Domestic channels"});
                case "educational":
                    return new EducationalSubscription(2.5, 3, new List<string> { "Educational channels" });
                case "premium":
                    return new PremiumSubscription(10, 1, new List<string> { "Premium channels" });
                default:
                    throw new ArgumentException("Неправильний тип підписки");
            }
        }
    }
}
