using file_duplicator_to_cloud.Models;

class Program
{
    static void Main()
    {
        var startup = new Startup();

        Console.WriteLine($"{startup.OAuthSettings.BearerToken}");
        Console.ReadLine();
    }
}
