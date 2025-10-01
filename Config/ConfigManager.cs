namespace SpaceFloridaLegacyApp.Config
{
    public static class ConfigManager
    {
        public static string GetConnectionString()
        {
            return "Server=localhost;Database=SpaceFloridaDB;User Id=admin;Password=your_password;";
        }
    }
}