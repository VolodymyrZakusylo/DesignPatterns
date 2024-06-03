using task3;

internal class Program
{
    private static void Main(string[] args)
    {
        Authenticator auth1 = Authenticator.GetInstance();
        Authenticator auth2 = Authenticator.GetInstance();
        if (auth1 == auth2)
        {
            Console.WriteLine("Одинак працює");
        }
        else
        {
            Console.WriteLine("Одинак не працює");
        }
    }
}