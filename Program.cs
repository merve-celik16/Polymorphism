namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BaseGeometrikSekil kare = new Kare { Genislik = 10, Yukseklik = 5 };
            BaseGeometrikSekil dikdortgen = new Dikdortgen { Genislik = 4, Yukseklik = 6 };
            Ucgen ucgen = new Ucgen { Genislik = 5, Yukseklik = 3 };

            Console.WriteLine($"Karenin Alanı: {kare.AlanHesapla()}");
            Console.WriteLine($"Dikdörtgenin Alanı: {dikdortgen.AlanHesapla()}");
            Console.WriteLine($"Üçgenin Alanı: {ucgen.AlanHesapla()}");
        }
    }
}
