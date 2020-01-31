using System;

namespace kolokwium2.zad2
{
    public class Package: IPackage
    {
        public string Localization { get; set; }
        public float Weight { get; set; }
        private int id;
        
        public int Send()
        {
            Console.WriteLine("Paczka nadana");
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
            Console.WriteLine($"Paczka o id: {id} znajduje sie w: {Localization}. Jej waga to: {Weight}");
        }

        public void Collect(int packageId)
        {
            Console.WriteLine("Paczka odebrana");
        }
    }
}