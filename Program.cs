using SpaceFloridaLegacyApp.Services;

namespace SpaceFloridaLegacyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Space Florida Launch Scheduler ===");
            LaunchService service = new LaunchService();
            service.DisplayUpcomingLaunches();
        }
    }
}