using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class MobileApp
    {
        public Subscription PurchaseSubscription(string subscriptionType)
        {
            SubscriptionFactory factory = new SubscriptionFactory();
            Subscription subscription = factory.CreateSubscription(subscriptionType);
            Console.WriteLine("Підписку куплено через мобільний застосунок");
            return subscription;
        }
    }
}
