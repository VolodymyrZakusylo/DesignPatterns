using ClassLibrary;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        WebSite website = new WebSite();
        MobileApp mobileApp = new MobileApp();
        ManagerCall managerCall = new ManagerCall();

        Subscription sub1 = website.PurchaseSubscription("Domestic");
        Subscription sub2 = mobileApp.PurchaseSubscription("Educational");
        Subscription sub3 = managerCall.PurchaseSubscription("Premium");
        sub1.GetInfo();
        sub2.GetInfo();
        sub3.GetInfo();
    }
}