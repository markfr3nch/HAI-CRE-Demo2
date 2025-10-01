namespace SpaceFloridaLegacyApp.Models
{
    public class Launch
    {
        public int Id { get; set; }
        public string MissionName { get; set; }
        public DateTime LaunchDate { get; set; }
        public string LaunchPad { get; set; }
    }
}