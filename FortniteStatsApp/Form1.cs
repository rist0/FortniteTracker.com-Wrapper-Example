using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using FortniteStatsApp.Fortnite;
using Telerik.Charting;
using Telerik.WinControls.UI;

namespace FortniteStatsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnClearUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
        }

        private void btnAddUsername_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() != "") lbUsernames.Items.Add(txtUsername.Text);
            txtUsername.Clear();
        }

        private void btnClearUsernameList_Click(object sender, EventArgs e)
        {
            lbUsernames.Items.Clear();
        }

        private void btnRemoveSelectedUsers_Click(object sender, EventArgs e)
        {
            var selectedItems = lbUsernames.SelectedItems;

            if (selectedItems.Count > 0)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    lbUsernames.Items.Remove(selectedItems[i]);
                }
            }
            else
            {
                Log("No users selected to remove.", nameof(LogType.Error));
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (lbUsernames.Items.Count > 0)
            {
                if (cbMode.SelectedIndex == -1)
                {
                    Log("No mode selected.", nameof(LogType.Error));
                    return;
                }

                chart.Series.Clear();
                chart.ShowTitle = true;
                chart.ShowLegend = true;

                var fortniteStatsList = new List<FortniteData>();

                Log("Attempting to gather data...", nameof(LogType.Info));
                foreach (string s in lbUsernames.Items)
                {
                    Log($"Gathering data for user {s}", nameof(LogType.Info));
                    fortniteStatsList.Add(await GetStatsByUsername("YOUR API KEY", "pc", s));
                    Log($"Successfully gathered data for user {s}", nameof(LogType.Info));

                    Log("Delaying for 2s...", nameof(LogType.Info));
                    await Task.Delay(2000);
                    Log("Successfully delayed...", nameof(LogType.Info));
                }
                Log("Successfully gathered data...", nameof(LogType.Info));

                Log("Adding series to chart...", nameof(LogType.Info));
                foreach (var stat in fortniteStatsList)
                {
                    switch (cbMode.Text)
                    {
                        case "Solo":
                            AddSeriesToChart(stat.EpicUserHandle, stat.Stats.Solo);
                            break;
                        case "Duo":
                            AddSeriesToChart(stat.EpicUserHandle, stat.Stats.Duo);
                            break;
                        case "Squad":
                            AddSeriesToChart(stat.EpicUserHandle, stat.Stats.Squad);
                            break;
                        case "Lifetime":
                            AddSeriesToChart(stat.EpicUserHandle, stat.LifetimeStats);
                            break;
                    }
                }
                Log("Successfully added series to chart...", nameof(LogType.Info));
            }
            else
            {
                Log("No users found in the list.", nameof(LogType.Error));
            }
        }

        private void AddSeriesToChart(string name, GameStats stats)
        {
            BarSeries barSeries = new BarSeries
            {
                LegendTitle = name,
                ShowLabels = true
            };

            barSeries.DataPoints.Add(new CategoricalDataPoint(stats.Matches.ValueInt, "Matches"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(stats.Wins.ValueInt, "Wins"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(stats.Kills.ValueInt, "Kills"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(stats.Kda.Value), "Kda"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(stats.WinRatio.Value), "Win Ratio"));

            chart.Series.Add(barSeries);
        }

        private void AddSeriesToChart(string name, LifetimeStats stats)
        {
            BarSeries barSeries = new BarSeries
            {
                LegendTitle = name,
                ShowLabels = true
            };
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToInt32(stats.MatchesPlayed), "Matches"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToInt32(stats.Wins), "Wins"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToInt32(stats.Kills), "Kills"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(stats.Kda), "Kda"));
            barSeries.DataPoints.Add(new CategoricalDataPoint(Convert.ToDouble(stats.WinPercentage.Replace("%", "")), "Win Ratio"));

            chart.Series.Add(barSeries);
        }

        private async Task<FortniteData> GetStatsByUsername(string token, string platform, string username)
        {
            var stats = await new FortniteStats().GetStatsByUsernameAsync(token, platform, username);
            return stats;
        }

        private void Log(string message, string logType)
        {
            Invoke((MethodInvoker) delegate
            {
                txtLogs.AppendText($@"{DateTime.Now} - {logType}: {message}{Environment.NewLine}");
            });
        }
    }
}
