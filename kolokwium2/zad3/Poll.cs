using System.ComponentModel.DataAnnotations;

namespace kolokwium2.zad3
{
    public class Poll
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public int D { get; set; }

        public Poll(int a, int b, int c, int d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        
        public (int, int, int, int, int) getNumberResults()
        {
            int sum = A + B + C + D;
            return (A, B, C, D, sum);
        }

        public string getStringResults()
        {
            int sum = A + B + C + D;

            return $"Glosy na a: {A * 100 / sum}%\n" +
                   $"Glosy na b: {B * 100 / sum}%\n" +
                   $"Glosy na c: {C * 100 / sum}%\n" +
                   $"Glosy na d: {D * 100 / sum}%\n";
        }
    }
}