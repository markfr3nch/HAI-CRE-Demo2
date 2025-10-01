using SpaceFloridaLegacyApp.Models;
using SpaceFloridaLegacyApp.Data;

namespace SpaceFloridaLegacyApp.Services
{
    public class LaunchService
    {
        private readonly LaunchRepository _repository;

        public LaunchService()
        {
            _repository = new LaunchRepository();
        }

        public void DisplayUpcomingLaunches()
        {
            var launches = _repository.GetUpcomingLaunches();
            foreach (var launch in launches)
            {
                Console.WriteLine($"\"{launch.MissionName}\" scheduled for {launch.LaunchDate.ToShortDateString()} at {launch.LaunchPad}");
            }
        }
    }
}