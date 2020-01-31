using System;
using System.Collections.Generic;
using kolokwium2.zad1;
using kolokwium2.zad2;
using kolokwium2.zad3;
using kolokwium2.zad5;

namespace kolokwium2
{
    class Program
    {
        static void Main(string[] args)
        {
            //////// zad 1 /////////
            
            // List<Gamer> listOfGamers = new List<Gamer>();
            // Random rnd = new Random();
            // DateTime start = new DateTime(2019, 10, 1);
            // int range = (DateTime.Today - start).Days;
            // DateTime RandomDay()
            // {
            //     return start.AddDays(rnd.Next(range));
            // }
            // for (int i = 0; i < 100; i++)
            // {
            //     listOfGamers.Add( new Gamer(
            //         rnd.Next(5000), 
            //         rnd.Next(200),
            //         RandomDay()
            //         )
            //     );
            // }
            // Ranking ranking = new Ranking();
            // ranking.getRankingByPoints(listOfGamers);
            // ranking.getRankingByWins(listOfGamers);
            // ranking.getRankingPointsToWins(listOfGamers);
            
            //////// zad 2 /////////
            
            // Letter letter = new Letter();
            // int id = letter.Send();
            // letter.Pass("Bielsko-Biala");
            // letter.Info();
            // letter.Collect(id);
            
            //////// zad 3 /////////
            
            // Random rnd = new Random();
            // Poll poll = new Poll(rnd.Next(25), rnd.Next(25), rnd.Next(25), rnd.Next(25));
            // (int a, int b, int c, int d, int sum) = poll.getNumberResults();
            // string results = poll.getStringResults();
            // Console.WriteLine($"A: {a}, B: {b}, C: {c}, D: {d}, sum: {sum}");
            // Console.WriteLine(results);
            
            //////// zad 5 /////////
            
            NumberReader numberReader = new NumberReader();
            numberReader.sumNumbersFromFile("data.txt");
        }
    }
}