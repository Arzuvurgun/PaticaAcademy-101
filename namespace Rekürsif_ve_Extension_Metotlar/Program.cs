using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace namespace_Rekürsif_ve_Extension_Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //REKÜRSİF-ÖZ YİNELEMELİ (KENDİ KENDİNİ ÇAĞIRAN FONKSİYONLAR)
            //Fonksiyon kendi kendini çağırma yeteneğine sahip olduğu için kullanır
            // 3^4 yani 3*3*3*3 değerini 2 şekilde yapacağız 
            // 1. for döngüsü ile
            int sonuc = 1;
            for (int i = 1; i < 5; i++)
            {
                sonuc = sonuc * 3;
                //Console.WriteLine(sonuc); içine yazarsak her ilerleyişi yazdırır 

            }
            Console.WriteLine(sonuc); // döngü dışındaki paranteze yazdırırsak eğer direkt sonucu verir.
            // 2. YÖNTEM
            Islemler instance = new Islemler();
            Console.WriteLine(instance.Us(3, 4));


            // EXTENSİON METOTLAR 
            //e hayatımıza giren, aynı kodu defalarca yazmak yerine,
            //bir kere yazıp her yerden erişebileceğimiz kolay kullanımı olan metotlardır.
            string ifade = "Rana TUNÇ Arzu VURGUN";
            Console.WriteLine(ifade.CheckSpaces());


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
    }
}


