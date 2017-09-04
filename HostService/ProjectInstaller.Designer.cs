namespace HostService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WebAPIServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.WebAPIServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // WebAPIServiceProcessInstaller
            // 
            this.WebAPIServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.WebAPIServiceProcessInstaller.Password = null;
            this.WebAPIServiceProcessInstaller.Username = null;
            // 
            // WebAPIServiceInstaller
            // 
            this.WebAPIServiceInstaller.DelayedAutoStart = true;
            this.WebAPIServiceInstaller.Description = "WebAPIServiceInstaller";
            this.WebAPIServiceInstaller.DisplayName = "WebAPIServiceInstaller";
            this.WebAPIServiceInstaller.ServiceName = "WebAPIService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WebAPIServiceProcessInstaller,
            this.WebAPIServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller WebAPIServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller WebAPIServiceInstaller;
    }
}