using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PatikaAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // atama ve işlemli atama operatörleri (=,+=,-=,/=)
            // mantıksal operatörler (||,&&,!) ve veya değil 
            // ilişkisel operatörler (==,!=,<,>,>=,<=)
            // aritmetik operatörler ( +,-,/,%,++,--)

            // atama işlemleri
            //int x = 3;
            //int y = 35;
            //y = y + 2;

            //Console.WriteLine(y);
            //y += 2;

            //Console.WriteLine(y);
            //y /= 1;

            //Console.WriteLine(y);
            //x *= 2;
            //Console.WriteLine(x);

            //MANTIKSAL OPERATÖRLER
            //bool isSucces = true;
            //bool isComleted = false;

            //if (isSucces && isComleted)
            //    Console.WriteLine("Perfect");
            //if (isComleted || isSucces)
            //    Console.WriteLine("Great");
            //if (isSucces && ! isComleted)
            //    Console.WriteLine("Fine!");

            // İLİŞKİLER OPERATÖRLER
            //int a = 5;
            //int b = 7;
            //bool sonuc = a < b;
            //Console.WriteLine(sonuc);

            //sonuc = a < b;
            //Console.WriteLine(sonuc);
            //sonuc = a > b;
            //Console.WriteLine(sonuc);
            //sonuc = a <= b;
            //Console.WriteLine(sonuc);
            //sonuc = a >= b;
            //Console.WriteLine(sonuc);
            //sonuc = a != b;
            //Console.WriteLine(sonuc);

            // ARİTMATİK OPERATÖELER
            //int s1 = 40;
            //int s2 = 20;
            //int sonuc1 = s1 + s2;
            //Console.WriteLine(sonuc1);
            //sonuc1 = s1 * s2;
            //Console.WriteLine(sonuc1);
            //sonuc1 = s1 / s2;
            //Console.WriteLine(sonuc1);
            //sonuc1 = s1 - s2;
            //Console.WriteLine(sonuc1);
            //sonuc1 = s2++;
            //Console.WriteLine(s2);
            //int sonuc2 = 89 % 5;
            //Console.WriteLine(sonuc2);



            // *****İmplit conversion (bilinçsiz dönüşüm)***
            //(byte)x  atanan değeri parantez içindeki değere dönüştürmeye çalışır

            byte a= 5;
            sbyte b = 30;
            short c = 30;
            int d = a + b + c;
            Console.WriteLine("d:"+d);
            long h = d;
            Console.WriteLine("h:" + h);
            float g = d;
            Console.WriteLine("g:"+g);

            string i = "ARZU";
            char k = 'j';
            object u = i + k + d;
            Console.WriteLine("u:"+u);



























            Console.ReadLine();

        }
    }
}
