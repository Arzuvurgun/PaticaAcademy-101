using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Encapsulation_ve_Property_KAPSÜLLEME_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation yani Kapsülleme kavramı bir özeliği başka sınıflardan saklamak ya da korumaktır.
        //     private string name; //field

        //public string Name //property
        //{
        //    get { return name; }
        //    set { name = value; }
        //}
         // get--geri döndürme set--yeni değer atama
           
            Ogrenci ogrenci = new Ogrenci("ARZU","VURGUN",283,2);
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Console.WriteLine("***2.öĞRENCİ***");
            Ogrenci ogrenci2= new Ogrenci("RANA", "TUNÇ", 610, 1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriniGetir();


            Console.ReadLine(); 

        }

        class Ogrenci
        {
            private string isim;
            private string soyisim;
            private int ogrenciNo;
            private int sinif;

            public string Isim
            {
                get { return isim; }
                set { isim = value; }

            }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
            public int Sinif { get => sinif;
                set
                {
                    if(value < 1)
                    {
                        Console.WriteLine("Sınıf en az 1 olmalıdır!!");
                        sinif = 1;
                    }
                    else
                    {
                        sinif = value;
                    }
              
                }
            }
                    
                   

            // yukarıdaki ve sonraki şekilde yani 2 farklı şekilde de get set kullanımı yapabiliriz.
             
            public Ogrenci(string isim,string soyisim,int ogrenciNo,int sinif)// parametreli olan
            {
                Isim = isim;
                Soyisim = soyisim;
                OgrenciNo = ogrenciNo;
                Sinif= sinif;

            }
            public Ogrenci() { } // boş olan
            
            public void OgrenciBilgileriniGetir()
            {
                Console.WriteLine("*****ÖĞRENCİ BİLGİLERİ*****");
                Console.WriteLine("Öğrenci adı:{0}",Isim);
                Console.WriteLine("Öğrenci soyadı:{0}",Soyisim);
                Console.WriteLine("Öğrenci numarası:{0}",OgrenciNo);
                Console.WriteLine("Öğrenci sınıfı:{0}",Sinif);
            }
            public void SinifAtlat()
            {
                Sinif = Sinif + 1;
            }
            public void SinifDusur()
            {
                Sinif = Sinif - 1;
            }
        }

    }

}
