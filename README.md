# FortniteTracker.com-Wrapper-Example
FortniteTracker.com C# API Wrapper + Example using WinForms

# Preview
![Fortnite Stats Example](https://i.imgur.com/laSjMVJ.png)

# More information
Target framework: `.NET Framework 4.6.1`

Example usage:
`var stats = await new FortniteStats().GetStatsByUsernameAsync(token, platform, username);`

`stats.EpicUserHandle` - for the handle of the user (username)

`stats.AccountId` - the account ID (hash) of the user

`stats.PlatformId` - the id of the platform of the user

`stats.PlatformName` - the name of the platform of the user

`stats.PlatformNameLong` - full name of the platform of the user

`stats.Stats` - returns the stats for solo/duo/squad games

`stats.Stats.Solo.Wins.Value` - an example to get the value of solo wins of a user

`stats.LifetimeStats` - returns the lifetime stats of the user

`stats.LifetimeStats.Kills` - an example to get the value of lifetime kills of a user
