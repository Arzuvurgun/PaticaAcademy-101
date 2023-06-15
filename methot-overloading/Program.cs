using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace methot_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // overloading == yani metotların aşırı yüklenmesi metot imzasının değiştirilerek aynı
            // isimdeki metodun birden farklı versiyonun yaratılmasıdır.
            //Out olarak kullanılmak istenen değişken önüne mutlaka "out" yazılmalıdır.
           //out değişkeninin bir ilk değeri olmak zorunda değildir.Hatırlarsanız bu ref kullanırken zorunluydu.
            //out int outSayi

            string sayi = "999";
            // int outSayi; bu şekilde de tanımlama yapanbiliriz.
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamsonucu);
            Console.WriteLine(toplamsonucu);

            // METOT AŞIRI YÜKLEME - Overloading 
            //yani metotların aşırı yüklenmesi metot imzasının değiştirilerek
            //aynı isimdeki metodun birden farklı versiyonun yaratılmasıdır.
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Arzu" , "VURGUN");
        }
        class Metotlar
        {
            public void Topla(int a, int b,out int toplam)
            {
                toplam = a + b;
            }
            //***AŞIRI YÜKLEME YAPMIŞ OLDUK***
            public void EkranaYazdir(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdir(int veri)
            {
                Console.WriteLine(veri);
            }
            // ALDIĞI 2 VERİYİ EKRANA YAZDIRMA
            public void EkranaYazdir(string veri1, string veri2)
            {
                Console.WriteLine(veri1+" "+ veri2);
            }
        }
    }

}
