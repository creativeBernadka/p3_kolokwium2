using System;
using System.Collections.Generic;
using System.Linq;

namespace kolokwium2.zad1
{
    public class Ranking
    {
        public void getRankingByPoints(List<Gamer> gamers)
        {
            gamers.Sort((first, second) => first.Points.CompareTo(second.Points));
            int i = gamers.Count;
            foreach (var gamer in gamers)
            {
                Console.WriteLine($"#{i} Points: {gamer.Points}");
                i--;
            }
        }

        public void getRankingByWins(List<Gamer> gamers)
        {
            gamers.Sort((first, second) => first.Wins.CompareTo(second.Wins));
            int i = gamers.Count;
            foreach (var gamer in gamers)
            {
                Console.WriteLine($"#{i} Wins: {gamer.Wins}");
                i--;
            }
        }

        public void getRankingPointsToWins(List<Gamer> gamers)
        {
            List<Gamer> lastWeekPlayers = gamers.Where(gamer =>
                (DateTime.Today - gamer.LastActivity).TotalDays < 7)
                .ToList();
            lastWeekPlayers.Sort((first, second) =>
            {
                float firstRatio = first.Points / first.Wins;
                float secondRatio = second.Points / second.Wins;
                if (firstRatio < secondRatio) return -1;
                if (firstRatio == secondRatio) return 0;
                return 1;
            });
            
            int i = lastWeekPlayers.Count;
            foreach (var gamer in lastWeekPlayers)
            {
                Console.WriteLine($"#{i} Ratio: {gamer.Points/gamer.Wins} Points: {gamer.Points} Wins: {gamer.Wins}");
                i--;
            }
        }
    }
}