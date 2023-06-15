using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;


namespace Rekürsif_ve_Extension_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REKÜRSİF-ÖZ YİNELEMELİ (KENDİ KENDİNİ ÇAĞIRAN FONKSİYONLAR)
            //Fonksiyon kendi kendini çağırma yeteneğine sahip olduğu için kullanır
            // 3^4 yani 3*3*3*3 değerini 2 şekilde yapacağız 
            // 1. for döngüsü ile
            //int sonuc = 1;
            //for (int i = 1; i < 5; i++)
            //{
            //    sonuc = sonuc * 3;
            //    //Console.WriteLine(sonuc); içine yazarsak her ilerleyişi yazdırır 

            //}
            //Console.WriteLine(sonuc); // döngü dışındaki paranteze yazdırırsak eğer direkt sonucu verir.
            //// 2. YÖNTEM
            //Islemler instance =new Islemler();
            //Console.WriteLine(instance.Us(3,4));


            // EXTENSİON METOTLAR 
            //e hayatımıza giren, aynı kodu defalarca yazmak yerine,
            //bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
            string ifade = "Rana TUNÇ Arzu VURGUN";
            // Console.WriteLine(ifade.CheckSpaces());
            bool sonuc1 = ifade.CheckSpaces();
            Console.WriteLine(sonuc1);

            if (sonuc1) // boşluğu silen ya da başka bi karakterle değitiren if
            {
                Console.WriteLine(ifade.RemoteWhiteSpaces());
            }
            Console.WriteLine(ifade.MakeUpperSpaces());
            Console.WriteLine(ifade.MakeLowerSpaces());
            int[] dizi = { 1, 3, 7, 9, 10, 11, 12, 13, };
            dizi.SortArray();
            dizi.EkranaYazdir();
            int sayi = 5;
            sayi.IsEvenNumber();
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());

        }

        public class Islemler
        {
            public int Us(int sayi, int üs)
            {
                if (üs < 2)
                {
                    return sayi;

                }
                return Us(sayi, üs - 1) * sayi;
            }
            // Us(3,4)
            //Us(3,3)*3
            // Us (3,2)*3*3
            //us(3,1)*3*3*3
            // 3*3*3*3 =3^4=81

        }
    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        //CheckSpaces(string parametre) this ifadesini eklersek extension metotu haline gelir.
        {
            return param.Contains(" "); // contains bir string kütüphanesidir.
        }
        public static string RemoteWhiteSpaces(this string param)
        {
            string[] dizi = param.Split();         // bu stringi boşluklara göre ayır ve dizi yap
            return string.Join("", dizi);                       // string dizisini birleştir.
        }
        public static string MakeUpperSpaces(this string param) // büyük harflerden oluşan şekilde yaz ifadeyi
        {
            return param.ToUpper(); 
        }
        public static string MakeLowerSpaces(this string param) // küçük harflerden oluşan şekilde yaz ifadeyi
        {
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);  
            return param;
        }
        public static void EkranaYazdir (this int[] param)
        {
            foreach (int i in param)
            {
                Console.WriteLine(i);
            }   
        }
        // verilen int sayının çift olup olmadığını kontrol eden metot
        public static bool IsEvenNumber(this int param)
        {
            return param %2 == 0;   
        }
        // verilen stringin ilk karakterini veren metot
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1); // ikinci kısıma yazdığımız kaç karakteri dönceğini gösterir
        }
    }

}