using System.ServiceProcess;

namespace ContactWindowsService
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new ContactWindowsService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
