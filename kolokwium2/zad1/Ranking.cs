using System;
using System.Collections.Generic;

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
    }
}