using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_arayüz_
{
    public class SmsLogger : ILogger
    {
        public void WriteLog()
        {
            //throw new NotImplementedException(); // implement etme yöntemi eğer yapmazsak hata alırız
            Console.WriteLine("SMS olarak log yazar.");
        }

    }
}
