using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace patika_ödev1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Ödev 1
            //1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n)
            //.Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
            //2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin(n, m).Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            //********1.SORU*****

            //Console.Write("Kaç adet sayı girmek istiyorsunuz?");
            //int n = int.Parse(Console.ReadLine());

            //int[] sayilar = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Lütfen sayıyı giriniz: ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Girdiğiniz çift sayılar:");
            //foreach (int sayi in sayilar)
            //{
            //    if (sayi % 2 == 0)
            //        Console.WriteLine(sayi);
            //}

            //*********2.SORU****

            //Console.Write("1. sayıyı giriniz:");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("2. sayıyı giriniz:");
            //int m = int.Parse(Console.ReadLine());

            //int[] sayilar = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Lütfen sayıyı giriniz: ");
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (int sayi in sayilar)
            //{
            //    if ( sayi==m)
            //    {
            //        Console.Write("m'ye eşit:"+sayi);
            //    }

            //}

            //********3.SORU*******

            //Console.Write("Lütfen sayıyı giriniz:");
            //int n =int.Parse(Console.ReadLine());
            //string[] kelimeler=new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Kelimeleri giriniz:");
            //    kelimeler[i] = Console.ReadLine();
            //}
            //Console.WriteLine("Girilen kelimeler sondan başa doğru şu şekildedir:");
            //for (int i = n-1; i >=0; i--)                                                  
            //{
            //    Console.WriteLine(kelimeler[i]);
            //}

            //**********4.SORU*******
           Console.Write("Bir cümle giriniz:");
           string cumle=Convert.ToString(Console.ReadLine());
           string[] kelimeler= cumle.Split(' ');// kelime sayısını bulma
           Console.WriteLine("Kelime sayısı:"+kelimeler.Length);

            int harfsayisi = 0;
            foreach (string kelime in kelimeler)
            {
                harfsayisi += kelime.Length;

            }
            Console.WriteLine("Harf sayısı:" + harfsayisi);





            Console.ReadLine();
            
        }
    }
}





