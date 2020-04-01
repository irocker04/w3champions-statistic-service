namespace W3ChampionsStatisticService.PlayerOverviews
{
    public class PlayerOverview
    {
        public PlayerOverview(string battleTag)
        {
            Id = battleTag;
            Name = battleTag.Split("#")[0];
            BattleTag = battleTag.Split("#")[1];
        }

        public string Id { get; set; }
        public string BattleTag { get; set; }
        public string Name { get; set; }
        public int TotalLosses { get; set; }
        public int TotalWins { get; set; }
        public int Games => TotalLosses + TotalWins;
        public double Winrate => TotalWins / (double)(TotalWins + TotalLosses);
        public int MMR { get; set; }

        public void RecordWin(bool playerRawWon)
        {
            if (playerRawWon)
            {
                TotalWins++;
            }
            else
            {
                TotalLosses++;
            }
        }
    }
}