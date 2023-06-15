using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_arayüz_
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException(); duruma göre kullanabilir zorunluluğu yok
            Console.WriteLine("Dosyaya long yazar.");
        }
    }
}
