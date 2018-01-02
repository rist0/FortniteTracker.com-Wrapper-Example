using Newtonsoft.Json;

namespace FortniteStatsApp.Fortnite
{
    class LifetimeStatsObject
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
