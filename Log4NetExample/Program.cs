using System;
using log4net;
using log4net.Config;

namespace Log4NetExample
{
    static class Program
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config"));

            string text = Console.ReadLine();

            log.Info(text);

            log.Debug(DateTime.Now + " : " + text);


            Console.WriteLine("Hit enter");
            log.Debug(DateTime.Now + " : " + text);

            Console.ReadKey();
        }
    }
}
