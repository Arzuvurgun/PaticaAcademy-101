using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace classlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        class SinifAdi
            //    {
            //        [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            //[Erişim Belirleyici]
            //        [Geri Dönüş Değerinin Tipi]
            //        MetotAdi([Parametreler])
            //        {
            //            //Metot Gövdesi
            //        }
            //    }



            // ***ERİŞİM BELİRLEYİCİLER****
            //1.Public : Her yerden erişilebiliz
            //2.Private : Sadece tanımlandığı sınıf içerisinden erişilebiliriz
            //3.Internal : Sadece bulunduğu proje içerisinden erişilebilir
            //4.Protected : Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.


            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Arzu";
            calisan1.Soyad = "VURGUN";
            calisan1.No = 72817297;
            calisan1.Departman = "Yazılım";
            calisan1.CalisanBilgileri();
            Console.WriteLine("**********");
            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Rana";
            calisan2.Soyad = "TUNÇ";
            calisan2.No = 8129129;
            calisan2.Departman = "Yazılım";
            calisan2.CalisanBilgileri();
            Console.WriteLine("**********");

            Calisan calisan3= new Calisan();
            calisan3.Ad = "Emre";
            calisan3.Soyad = "ŞAHİN";
            calisan3.No = 123456;
            calisan3.Departman = "Yazılım Mühendisliği";
            calisan3.CalisanBilgileri();

            Console.ReadLine();



        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public  string Departman;
      
        
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışanın Adı:{0}",Ad);
            Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışanın NUmarası:{0}",No);
            Console.WriteLine("Çalışanın Departmanı:{0}",Departman);
        }
    }

}
