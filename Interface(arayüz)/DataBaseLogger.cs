using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_arayüz_
{
    public class DataBaseLogger : ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Database'e yazar.");
        }
    }
}
