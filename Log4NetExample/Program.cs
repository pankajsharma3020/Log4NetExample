using System;
using log4net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Config;

namespace Log4NetExample
{
    static class Program
    {


        static void Main(string[] args)
        {
            BasicConfigurator.Configure();
            ILog log = LogManager.GetLogger(typeof(Program));

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
