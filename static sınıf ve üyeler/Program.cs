using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace static_sınıf_ve_üyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Çalışsan sayısı:{0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("RANA","TUNÇ","YAZILIM");
            Console.WriteLine("Çalışan sayısı: {0}",Calisan.CalisanSayisi); 
            Calisan calisan1 = new Calisan("RANA", "TUNÇ", "YAZILIM");
            Calisan calisan2= new Calisan("RANA", "TUNÇ", "YAZILIM");
            Console.WriteLine("Çalışan sayısı: {0}", Calisan.CalisanSayisi);

            Console.WriteLine("Toplama işleminin sonucu:{0}", İslemler.Topla(100, 200));
            Console.WriteLine("Çıkarma işleminin sonucu:{0}", İslemler.Çıkar(200, 100));

            Console.ReadLine(); 


        }
        class Calisan
        {
            private static int calisansayisi;
            public static int CalisanSayisi { get => calisansayisi; } //set => calisansayisi = value; }setırı kapatırsam eğer sadece çalışan sınıfından değiştirebilirim.

            private string İsim;
            private string Soyisim;
            private string Departman;

            // staticlerin bir erişim belirleyicileri olmaz.
            // static classlarda her şey static olmalıdır static olmayan hiçbir şey kullanılmaz (metot,property vs..)
            static Calisan()
            {
                calisansayisi = 0;

            }


            public Calisan(string isim, string soyisim, string departman)
            {
                İsim = isim;
                Soyisim = soyisim;
                Departman = departman;
                calisansayisi++;
            }
          
           
        }
        static class İslemler
        {
            public static long Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }
            public static long Çıkar(int sayi1, int sayi2)
            {
                return sayi1 - sayi2;
            }
        }


    }
}
