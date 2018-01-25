using System.ComponentModel;
using System.Configuration.Install;

namespace ContactWindowsService
{
    [RunInstaller(true)]
    public partial class ContactWindowsServiceInstaller : Installer
    {
        public ContactWindowsServiceInstaller()
        {
            InitializeComponent();
        }
    }
}
