using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("bir sayi giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi" + sayi);
            }
            catch (Exception ex)
            {

                Console.WriteLine("HATA!"+ ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("işlem tamamlandı");
            }


            Console.ReadLine();
        }
    }
}
