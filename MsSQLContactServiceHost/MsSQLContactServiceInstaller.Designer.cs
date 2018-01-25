namespace MsSQLContactServiceHost
{
    partial class MsSQLContactServiceInstaller
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MsSQLContactServiceHostProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.MsSQLContactServiceHost = new System.ServiceProcess.ServiceInstaller();
            // 
            // MsSQLContactServiceHostProcessInstaller
            // 
            this.MsSQLContactServiceHostProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.MsSQLContactServiceHostProcessInstaller.Password = null;
            this.MsSQLContactServiceHostProcessInstaller.Username = null;
            // 
            // MsSQLContactServiceHost
            // 
            this.MsSQLContactServiceHost.DelayedAutoStart = true;
            this.MsSQLContactServiceHost.Description = "MsSQL Contact Service (hosted by Windows NT service)";
            this.MsSQLContactServiceHost.DisplayName = "MsSQL Contact Service";
            this.MsSQLContactServiceHost.ServiceName = "MsSQLContactServiceHost";
            // 
            // MsSQLContactServiceInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MsSQLContactServiceHostProcessInstaller,
            this.MsSQLContactServiceHost});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MsSQLContactServiceHostProcessInstaller;
        private System.ServiceProcess.ServiceInstaller MsSQLContactServiceHost;
    }
}