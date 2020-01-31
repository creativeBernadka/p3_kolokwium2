using System;

namespace kolokwium2.zad1
{
    public class Gamer
    {
        public int Points { get; set; }
        public int Wins { get; set; }
        public DateTime LastActivity { get; set; }

        public Gamer(int points, int wins, DateTime lastActivity)
        {
            Points = points;
            Wins = wins;
            LastActivity = lastActivity;
        }
    }
}