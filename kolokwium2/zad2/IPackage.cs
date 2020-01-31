namespace kolokwium2.zad2
{
    public interface IPackage
    {
        int Send();
        void Pass(string localization);
        void Info();
        void Collect(int packageId);
    }
}