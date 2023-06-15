using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance_kalıtım_
{
   public class Hayvanlar:Canlılar
   {
        public void Adaptasyon()
        {
            Console.WriteLine("Canlılar adaptasyon kurar.");
        }
   }
    public class Sürüngenler:Hayvanlar
    {
        public void SürünerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }
    public class Kuslar:Hayvanlar
    {
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }
    }
   
}
