using System;

namespace kolokwium2.zad5
{
    public class NumberReader
    {
        public void sumNumbersFromFile(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            int sum = 0;
            foreach (var line in lines)
            {
                sum += Int32.Parse(line);
            }

            string content = $"{sum}";
            System.IO.File.WriteAllText("result.txt", content);
        }
    }
}