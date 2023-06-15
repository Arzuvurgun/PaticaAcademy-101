using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****** METHOTLAR-FONKSİYONLAR *******
            // erişim belirleyici, geri dönüş tipi, metotadı(parametre listesi)

            int a=4; int b=5;
            int topla=a+b;  
            Console.WriteLine(topla);

            int toplananDeger = Topla(7, 9);
            Console.WriteLine(toplananDeger);

            Metotlar ornek= new Metotlar(); 
            ornek.EkranaYazdir(Convert.ToString(topla));

         
            int sonuc2=ornek.ArttirVetopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

            int sonuc3=ornek.ArttirVetopla1(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc3));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }
       static int Topla(int deger1,int deger2)
        {
            return(deger1 + deger2);
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirVetopla(int deger1,int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return( deger1 + deger2);   
        }
        public int ArttirVetopla1( ref int deger1,ref int deger2) // referans alma
        {
            deger1 += 1;
            deger2 += 1;
            return (deger1 + deger2);
        }
        // ref kullanımı
        //Bir fonksiyona parametre aktarırken
        //değer veya referans tipinde paramtere verebiliriz.
        //Referans olarak iletilmek istenen değişkenin önüne "ref" yazılmalıdır.
        //ref olarak metoda verilen değişkenin mutlaka bir başlangıç değeri olmak zorundadır.
    }

}
