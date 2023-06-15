using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace interface_arayüz__örnek
{
    public class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("*******İNTERFACE KODLARI****");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            Console.WriteLine("***********");

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());
            Console.WriteLine("*************");

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.HangiMarkanınAracı().ToString());
            Console.WriteLine(corolla.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());

            Console.WriteLine("*********ABSTRACT SINIFTAKİ KODLARIN ÇIKTISI");

            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.HangiMarkanınAracı().ToString());
            Console.WriteLine(focus1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(focus1.StandartRengiNe().ToString());
            Console.WriteLine("*************");

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.HangiMarkanınAracı().ToString());
            Console.WriteLine(civic1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(civic1.StandartRengiNe().ToString());
            Console.WriteLine("*************");

            NewCorolla corolla1 = new NewCorolla();
            Console.WriteLine(corolla1.HangiMarkanınAracı().ToString());
            Console.WriteLine(corolla1.KacTekerlektenOlusur().ToString());
            Console.WriteLine(corolla1.StandartRengiNe().ToString());




            Console.ReadLine();

        }
    }
}