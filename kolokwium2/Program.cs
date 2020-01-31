using System;
using System.Collections.Generic;
using kolokwium2.zad1;

namespace kolokwium2
{
    class Program
    {
        static void Main(string[] args)
        {
            // zad 1
            List<Gamer> listOfGamers = new List<Gamer>();
            Random rnd = new Random();
            DateTime start = new DateTime(2019, 10, 1);
            int range = (DateTime.Today - start).Days;
            DateTime RandomDay()
            {
                return start.AddDays(rnd.Next(range));
            }
            for (int i = 0; i < 100; i++)
            {
                listOfGamers.Add( new Gamer(
                    rnd.Next(5000), 
                    rnd.Next(200),
                    RandomDay()
                    )
                );
            }
            Ranking ranking = new Ranking();
            ranking.getRankingByPoints(listOfGamers);
            ranking.getRankingByWins(listOfGamers);
            ranking.getRankingPointsToWins(listOfGamers);
        }
    }
}