using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FortniteStatsApp.Fortnite
{
    class FortniteData
    {
        private readonly string _token;

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("platformId")]
        public int PlatformId { get; set; }

        [JsonProperty("platformName")]
        public string PlatformName { get; set; }

        [JsonProperty("platformNameLong")]
        public string PlatformNameLong { get; set; }

        [JsonProperty("epicUserHandle")]
        public string EpicUserHandle { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("lifeTimeStats")]
        public List<LifetimeStatsObject> LifetimeStatsObjects { get; set; }

        public LifetimeStats LifetimeStats { get; set; } = new LifetimeStats();

        public FortniteData(string token)
        {
            _token = token;
        }
    }
}
