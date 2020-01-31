namespace kolokwium2.zad4
{
    public class TrafficSignal
    {
        public int CurrentColor;
        public int PreviousColor;
        public int Id;

        public TrafficSignal(int currentColor, int previousColor, int id)
        {
            CurrentColor = currentColor;
            PreviousColor = previousColor;
            Id = id;
        }
    }
}