using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface_arayüz_
{
    public class LogManager:ILogger
    {
        public ILogger _logger; // intance yarattık.
        public LogManager(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteLog()
        {
            _logger.WriteLog(); 
        }
    }
}
