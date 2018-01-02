using Newtonsoft.Json;

namespace FortniteStatsApp.Fortnite
{
    class GameStats
    {
        [JsonProperty("top1")]
        public StatsObject Wins { get; set; }

        [JsonProperty("kills")]
        public StatsObject Kills { get; set; }

        [JsonProperty("kd")]
        public StatsObject Kda { get; set; }

        [JsonProperty("winRatio")]
        public StatsObject WinRatio { get; set; }

        [JsonProperty("matches")]
        public StatsObject Matches { get; set; }

        [JsonProperty("minutesPlayed")]
        public StatsObject MinutesPlayed { get; set; }

        [JsonProperty("kpm")]
        public StatsObject KillsPerMinute { get; set; }

        [JsonProperty("kpg")]
        public StatsObject KillsPerGame { get; set; }
    }
}
