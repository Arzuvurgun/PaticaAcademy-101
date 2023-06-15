using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar); // pazar gününü yazdırır.
            Console.WriteLine((int)Gunler.Salı); // numaralanmış indeks değerini yazdırır

        //soğuk = 10,
        //normal = 25,
        //sıcak = 35,
        //çokSıcak = 40
            int sıcaklık = 30;
            if (sıcaklık < 20)
                Console.WriteLine("Hava bugün normal");
            else if (sıcaklık >= 32)
                Console.WriteLine("Hava bugün sıcak");
            else if (sıcaklık < 20)
                Console.WriteLine("Hava bugün soğuk");
            else if (sıcaklık > 25 && sıcaklık < 40)
                Console.WriteLine("Hava bugün sıcak");

            Console.ReadLine();
        }
    }
    enum Gunler // sıralı ifadelerde kullanılır okunabilirliği yüksektir.
    {
        Pazartesi,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum Sıcaklık
    {
        soğuk=10,
        normal=25,
        sıcak=35,
        çokSıcak=40

    }

}
