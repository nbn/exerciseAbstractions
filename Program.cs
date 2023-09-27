// See https://aka.ms/new-console-template for more information

internal class Program
{
    public static void Main(string[] args)
    {
        Sinatra sinatra = new Sinatra();
        Console.WriteLine($"The singer is {sinatra}"); // 1) Use getName
        
        // 2) Uncomment this
        // sinatra.Sing();
        
        ISinger s = null; // 3) Assign New Sinatra instead of null
        Console.WriteLine($"The singer is {s.GetName()}");
        s.Sing();

    }

    interface ISinger
    {
        String GetName();
        void Sing();

    }

    class Sinatra
    {
        
    }
}