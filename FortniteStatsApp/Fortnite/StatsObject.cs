using Newtonsoft.Json;

namespace FortniteStatsApp.Fortnite
{
    class StatsObject
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("valueInt")]
        public int ValueInt { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("percentile")]
        public string Percentile { get; set; }

        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
    }
}
