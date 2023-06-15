using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KalıtımPatika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Virtual metotlar ile nesne yönelimli programlama ilkesi olan polymorphism'i uygularız.
            // Sanal metotlar kalıtım alınan yani miras veren sınıf içerisinde yazılan ve daha sonra alt sınıflarda yeniden yazılabilen metotlardır.
            // Bunu da virtual ve override anahtar kelimeleri sağlar
            TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.Beslenme();
            tohumluBitkiler.Bosaltim();
            tohumluBitkiler.Solunum();
            tohumluBitkiler.TohumCogaltma();
            tohumluBitkiler.UyaranlaraTepki();



            Console.WriteLine("*************");

            Kuslar kuslar = new Kuslar();
            kuslar.Solunum();
            kuslar.Bosaltim();
            kuslar.Adaptasyon();
            kuslar.Bosaltim();
            kuslar.Ucmak();
            kuslar.Beslenme();
            kuslar.UyaranlaraTepki();
            Console.ReadLine();


        }
        //public sealed class Canlılar // bir sınıfın başka sınıflar tarafından türetilmesini engellemek için "SEALED" ananhtar kelimesini kullanırız.
        public class Canlılar 
        {
            public void Solunum()
            {
                Console.WriteLine("Canlılar solunum yapar");
            }
            public void Beslenme()
            {
                Console.WriteLine("Canlılar beslenir.");
            }
            public void Bosaltim()
            {
                Console.WriteLine("Canlılar boşaltım yapar.");
            }
            public virtual void UyaranlaraTepki()
            {
                Console.WriteLine("Canlılar uyaranlara tepki verir."); // virtual anahtar kelime
            }
       

            

        }
        public class Hayvanlar : Canlılar
        {
            public void Adaptasyon()
            {
                Console.WriteLine("Canlılar adaptasyon kurar.");
            }
            public override void UyaranlaraTepki() // hangi metotlat virtual anahtar kelimesi alırsa onu çağırır.
            {
                base.UyaranlaraTepki();
                Console.WriteLine("Hayvanlar temasa tepki verir.");
            }

        }
        public class Sürüngenler : Hayvanlar
        {
            public void SürünerekHareketEtmek()
            {
                Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
            }
        }
        public class Kuslar : Hayvanlar
        {
            public void Ucmak()
            {
                Console.WriteLine("Kuşlar uçar.");
            }

        }
        public class Bitkiler : Canlılar
        {
            protected void Fotosentez() // sadece kendi sınıfından miras alma
            {
                Console.WriteLine("Bitkiler fotosentez yapar.");
            }
            public override void UyaranlaraTepki()
            {
                //base.UyaranlaraTepki();
                Console.WriteLine("Bitkiler güneşe tepki verir.");
            }


        }
        public class TohumluBitkiler : Bitkiler
        {
            public TohumluBitkiler() //yapıcı  metot sayesinde kullanılır hale gelir.
            {
                base.Fotosentez(); // kalıtım aldığım metotların üst sınıfına erişmemizi sağlar.
            }
            public void TohumCogaltma()
            {
                Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
            }

        }
        public class TohumsuzBitkiler : Bitkiler
        {
            public TohumsuzBitkiler()
            {
                base.Fotosentez();
            }
            public void SporlaCogalma()
            {
                Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
            }
        }
    }
}
