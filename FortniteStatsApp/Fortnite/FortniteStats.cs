using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FortniteStatsApp.Fortnite
{
    class FortniteStats
    {
        /// <summary>
        /// Get stats by username for specific platform
        /// </summary>
        /// <param name="token">API token</param>
        /// <param name="platform">Platform to get stats for. Can be: "pc", "psn" or "xbl"</param>
        /// <param name="username">The username of the player to get stats for (for PSN/XBL, use the account name you used to register on Epic Games)</param>
        /// <returns></returns>
        public async Task<FortniteData> GetStatsByUsernameAsync(string token, string platform, string username)
        {
            string response;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("TRN-Api-Key", token);
                response = await client.GetStringAsync($"https://api.fortnitetracker.com/v1/profile/{platform}/{username}");
            }

            var fw = JsonConvert.DeserializeObject<FortniteData>(response);

            foreach (LifetimeStatsObject stat in fw.LifetimeStatsObjects)
            {
                fw.LifetimeStats.LifetimeStatsData(stat.Key, stat.Value);
            }

            return fw;
        }
    }
}
