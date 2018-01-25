namespace ContactWindowsService
{
    partial class ContactWindowsServiceInstaller
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
            this.ContactWindowsServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ContactWindowsService = new System.ServiceProcess.ServiceInstaller();
            // 
            // ContactWindowsServiceProcessInstaller
            // 
            this.ContactWindowsServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ContactWindowsServiceProcessInstaller.Password = null;
            this.ContactWindowsServiceProcessInstaller.Username = null;
            // 
            // ContactWindowsService
            // 
            this.ContactWindowsService.DelayedAutoStart = true;
            this.ContactWindowsService.Description = "Contact service for \"Address Book\"";
            this.ContactWindowsService.DisplayName = "Contact Service";
            this.ContactWindowsService.ServiceName = "ContactWindowsService";
            this.ContactWindowsService.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ContactWindowsServiceInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ContactWindowsServiceProcessInstaller,
            this.ContactWindowsService});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ContactWindowsServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller ContactWindowsService;
    }
}