using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace Interface_arayüz_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sınıfların içermesi gereken metotların imzalarının yer aldığı,
            //özelliklerin tanımlandığı bir taslak gibi düşünebiliriz.== ARAYÜZ
            //Interface içerisindeki property'lere bir değer ataması yapılmaz
            //metotların ise gövdesi yazılmaz. Sadece implemente eden sınıfın ne iş yaptığının bir arayüzüdür interface'ler.
            //Ve bir sınıf aynı anda birden fazla arayüzden kalıtım alabilir.
            //Kalıtım alan sınıfın sorumluluğunun çerçevesinin çizilmesine yardımcı olur diyebilir
            //Aynı sorumluluğu başka bir yoğurt yiyiş tarzıyla yapması gereken bir sınıf geldiğinde aynı interface den 
            //kalıtım alır ama yapacağı işi farklı şekilde yapar.

            FileLogger fileLogger = new FileLogger();
            fileLogger.WriteLog();
            
            DataBaseLogger dataBaseLogger = new DataBaseLogger();   
            dataBaseLogger.WriteLog();

            SmsLogger smsLogger= new SmsLogger();
            smsLogger.WriteLog();

            LogManager logManager=new LogManager(new FileLogger());
            logManager.WriteLog();

            Console.ReadLine(); 

        }
    }
}
