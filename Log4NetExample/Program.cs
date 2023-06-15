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

            //ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            //log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

            log.Info("Hello logging world!");

            log.Debug("Hello logging world!");

            log.Debug("Did it again!");

            Console.WriteLine("Hit enter");


            Console.ReadKey();
        }
    }
}
