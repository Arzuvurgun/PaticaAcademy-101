using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Struct_Yapı__Kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class kullanmanızı gerektirecek kadar komplex olmayan yapılarınız varsa ve verileri kapsüllemek işinizi görecekse yapıları tercih edebilebilir.
            //Class lar referans tipli özellikler gösterir, Yapılar ise değer tipli özellikler gösterirler. En temel fark budur.Diğer struct ya da sınıflardan kalıtım almazlar.
            //Interface'lerden kalıtım alabilirler.
            //new anahtar sözcüğü ile nesneleri yaratılabilir.
            //Sınıflar gibi metot, property ve field'lardan oluşurlar
            //Sınıf içerisinde struct, struct içerisinde de sınıf oluşturulabilir.
            //Static üye barındırabilirler.

            Dikdörtgen dikdörtgen=new Dikdörtgen();
            dikdörtgen.KısaKenar = 5;
            dikdörtgen.UzunKenar = 7;
            Console.WriteLine("Class Alan hesabı: {0}", dikdörtgen.AlanHesdapla());

            Dikdörtgen_struct dikdörtgen_Struct; // new ile oluşturmadanda sonucu elde edebiliriz bunu classlarla yapamayız.
            dikdörtgen.KısaKenar = 4;
            dikdörtgen.UzunKenar = 6;
            Console.WriteLine("Struct Alan hesabı:{0}", dikdörtgen.AlanHesdapla());

            Console.ReadLine(); 
        }
        class Dikdörtgen
        {
            public int KısaKenar;
            public int UzunKenar;
            public long AlanHesdapla()
            {
                return this.KısaKenar * this.UzunKenar;
            }
        }
        struct Dikdörtgen_struct
        {
            public int KısaKenar;
            public int UzunKenar;
            public long AlanHesdapla()
            {
                return this.KısaKenar*this.UzunKenar;
            }

        }

    }
}
