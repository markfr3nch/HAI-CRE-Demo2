using SpaceFloridaLegacyApp.Models;
using System.Data.SqlClient;

namespace SpaceFloridaLegacyApp.Data
{
    public class LaunchRepository
    {
        private readonly string _connectionString;

        public LaunchRepository()
        {
            _connectionString = ConfigManager.GetConnectionString();
        }

        public List<Launch> GetUpcomingLaunches()
        {
            List<Launch> launches = new List<Launch>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT TOP 5 Id, MissionName, LaunchDate, LaunchPad FROM Launches ORDER BY LaunchDate ASC";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    launches.Add(new Launch
                    {
                        Id = reader.GetInt32(0),
                        MissionName = reader.GetString(1),
                        LaunchDate = reader.GetDateTime(2),
                        LaunchPad = reader.GetString(3)
                    });
                }
            }
            return launches;
        }
    }
}