using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace MsSQLContactServiceHost
{
    [RunInstaller(true)]
    public partial class MsSQLContactServiceInstaller : System.Configuration.Install.Installer
    {
        public MsSQLContactServiceInstaller()
        {
             InitializeComponent();

            //MsSQLContactServiceHostProcessInstaller = new ServiceProcessInstaller
            //{
            //    Account = ServiceAccount.LocalSystem
            //};

            //MsSQLContactServiceHost = new ServiceInstaller
            //{
            //    ServiceName = "MsSQLContactServiceHost",
            //    DisplayName = "MsSQL Contact Service",
            //    Description = "MsSQL Contact Service (hosted by Windows NT service)",
            //    StartType = ServiceStartMode.Automatic
            //};

            Installers.Add(MsSQLContactServiceHostProcessInstaller);
            Installers.Add(MsSQLContactServiceHost);
        }
    }
}
