using Newtonsoft.Json;

namespace FortniteStatsApp.Fortnite
{
    class Stats
    {
        [JsonProperty("p2")]
        public GameStats Solo { get; set; }

        [JsonProperty("p10")]
        public GameStats Duo { get; set; }

        [JsonProperty("p9")]
        public GameStats Squad { get; set; }
    }
}
