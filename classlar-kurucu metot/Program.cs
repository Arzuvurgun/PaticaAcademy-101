using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classlar_kurucu_metot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** 1.ÖĞRENCİ*****");
            Ogrenci ogrenci1=new Ogrenci("ARZU","VURGUN",22,"YÖNETİM BİLİŞİM SİSTEMLERİ"); // kurucu metotdu yazdığımızda oluşturduğumuz new kısmı yani nesne oluşturduğumuz kısım hata verebilir.
             ogrenci1.OgrenciBilgileri();

            Console.WriteLine("**** 2. ÖĞRENCİ***");
            Ogrenci ogrenci2=new Ogrenci();
            ogrenci2.Ad = "Rana";
            ogrenci2.Soyad = "TUNÇ";
            ogrenci2.Yas = 22;
            ogrenci2.Bölüm = "Yönetim Bilişim Sistemleri";
            ogrenci2.OgrenciBilgileri();

            Console.WriteLine("****** 3.ÖĞRENCİ***"); // KURUCU METOT SAYESİNDE BÖYLE BİR ŞEKİLDE DAHA OKUNUR ŞEKİLDE YAPABİLİRİZ.
            Ogrenci ogrenci3=new Ogrenci("ARZU",22);
            ogrenci3.OgrenciBilgileri();

            Console.ReadLine();




        }
    }
    class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public int Yas;
        public string Bölüm;
        
        public Ogrenci(string ad,string soyad,int yas,string bölüm) // bu benim kurucu metodum // kurucu fonksiyon overloading edilebilir yani aşırı yüklenebilir.
        {
           // Ad = ad; böyle de yazılabilir
           this.Ad = ad;    
           this.Soyad = soyad;
           this.Yas = yas;
           this.Bölüm = bölüm;

        }
        public Ogrenci(string ad,int yas)
        {
            this.Ad = ad;
            this.Yas = yas;
        }
        public Ogrenci() { } // bunu yaparsak normal yazdığım öğrenci1de aynı şekilde yazmaya devam eder hata almaz.
        public void OgrenciBilgileri()
        {
            Console.WriteLine("Öğrencinin adı:{0}",Ad);
            Console.WriteLine("Öğrencinin soyadı:{0}",Soyad);
            Console.WriteLine("Öğrencinin yaşı:{0}",Yas);
            Console.WriteLine("Öğrencinin bölümü:{0}", Bölüm);
        }
    }
}
