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
    }
}