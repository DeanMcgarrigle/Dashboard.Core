using System;
using System.ServiceProcess;
using Dashboard.Core.Installer;

namespace Dashboard.Core
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            var service = new WinService();
            service.Start();
            Console.WriteLine("Service Running...");
            Console.ReadLine();
#else
            RunService();
#endif
        }

        static void RunService()
        {
            var ServicesToRun = new ServiceBase[]
            {
                new WinService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
