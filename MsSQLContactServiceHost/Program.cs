using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MsSQLContactServiceHost
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// sc delete имя_службы
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MsSQLService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
