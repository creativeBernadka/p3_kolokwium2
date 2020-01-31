using System;

namespace kolokwium2.zad2
{
    public class Letter: IPackage
    {
        public string Localization { get; set; }
        public string Content { get; set; }
        private int id;
        
        public int Send()
        {
            Console.WriteLine("List nadany");
            Localization = "Baza";
            Random rnd = new Random();
            id = rnd.Next(1000);
            return id;
        }

        public void Pass(string localization)
        {
            Localization = localization;
        }

        public void Info()
        {
            Console.WriteLine($"List o id: {id} znajduje sie w: {Localization}");
            Console.WriteLine($"Jego tresc to: {Content}");
        }

        public void Collect(int packageId)
        {
            Console.WriteLine("List odebrany");
        }
    }
}