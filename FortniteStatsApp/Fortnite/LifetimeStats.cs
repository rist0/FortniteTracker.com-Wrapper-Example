namespace FortniteStatsApp.Fortnite
{
    class LifetimeStats
    {
        public string Top10S { get; set; }
        public string Top5S { get; set; }
        public string Top3S { get; set; }
        public string Top6S { get; set; }
        public string Top12S { get; set; }
        public string Top25S { get; set; }
        public string Score { get; set; }
        public string MatchesPlayed { get; set; }
        public string Wins { get; set; }
        public string WinPercentage { get; set; }
        public string Kills { get; set; }
        public string Kda { get; set; }
        public string KillsPerMinute { get; set; }
        public string TimePlayed { get; set; }

        public void LifetimeStatsData(string key, string value)
        {
            switch (key)
            {
                case "Top 10s":
                    Top10S = value;
                    break;
                case "Top 5s":
                    Top5S = value;
                    break;
                case "Top 3s":
                    Top3S = value;
                    break;
                case "Top 6s":
                    Top6S = value;
                    break;
                case "Top 12s":
                    Top12S = value;
                    break;
                case "Top 25s":
                    Top25S = value;
                    break;
                case "Score":
                    Score = value;
                    break;
                case "Matches Played":
                    MatchesPlayed = value;
                    break;
                case "Wins":
                    Wins = value;
                    break;
                case "Win%":
                    WinPercentage = value;
                    break;
                case "Kills":
                    Kills = value;
                    break;
                case "K/d":
                    Kda = value;
                    break;
                case "Kills Per Min":
                    KillsPerMinute = value;
                    break;
                case "Time Played":
                    TimePlayed = value;
                    break;
            }
        }
    }

}
