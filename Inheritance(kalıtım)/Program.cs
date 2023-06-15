using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_kalıtım_
{
    internal class Program
    {
        static void Main(string[] args)
        {
        TohumluBitkiler tohumluBitkiler = new TohumluBitkiler();
            tohumluBitkiler.Beslenme();
            tohumluBitkiler.Bosaltim();
            tohumluBitkiler.Solunum();
            tohumluBitkiler.TohumCogaltma();

          
            Console.WriteLine("*************");

            Kuslar kuslar = new Kuslar();
            kuslar.Solunum();
            kuslar.Bosaltim();
            kuslar.Adaptasyon();
            kuslar.Bosaltim();
            kuslar.Ucmak();
            kuslar.Beslenme();
            Console.ReadLine();
        }
    }
}
