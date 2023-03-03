namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> anahtarDeger = new MyDictionary<int, string>();
            anahtarDeger.Add(06, "Ankara");
            anahtarDeger.Add(07, "Antalya");
            anahtarDeger.Add(43, "Kütahya");
        }
    }
}