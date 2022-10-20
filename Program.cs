using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Cuma);
            Console.WriteLine((int)Gunler.Cumartesi);
            int Sıcaklık=32;
            if (Sıcaklık<=(int)HavaDurumu.Normal)
            {
                Console.WriteLine("Dışarıya çıkmak için havanın biraz daha isınmasını bekleyelim.");
            }
            else if(Sıcaklık>=(int)HavaDurumu.Sıcak)
            {
                Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if(Sıcaklık>=(int)HavaDurumu.Normal &&Sıcaklık<(int)HavaDurumu.CokSıcak)
            {
                Console.WriteLine("Hadi dışarı çıkalım.");
            }
        }
    }

    enum Gunler
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar

    }

    enum HavaDurumu
    {
        Soguk=5,        
        Normal=20,
        Sıcak=25,
        CokSıcak=30
    }
}
