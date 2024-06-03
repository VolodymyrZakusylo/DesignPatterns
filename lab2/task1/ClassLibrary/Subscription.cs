namespace ClassLibrary
{
    public class Subscription
    {
        public double MonthlyFee { get; set; }
        public int MinSubPeriod { get; set; }
        public List<string> Channels { get; set; }
        public Subscription(double monthlyFee, int minSubPeriod, List<string> channels)
        {
            MonthlyFee = monthlyFee;
            MinSubPeriod = minSubPeriod;
            Channels = channels;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Ціна за підписку:\n{MonthlyFee}\nМінімальний період підписки: {MinSubPeriod} місяців");
        }
    }
}