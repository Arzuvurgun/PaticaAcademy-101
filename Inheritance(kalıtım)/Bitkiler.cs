using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_kalıtım_
{
    public class Bitkiler:Canlılar
    {
        protected void Fotosentez() // sadece kendi sınıfından miras alma
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

    }
    public class TohumluBitkiler:Bitkiler
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
    public class TohumsuzBitkiler:Bitkiler
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

