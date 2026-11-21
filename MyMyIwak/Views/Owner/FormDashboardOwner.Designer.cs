namespace MyMyIwak.Views
{
    partial class FormDashboardOwner
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebar1 = new SidebarOwner();
            SuspendLayout();
            // 
            // sidebar1
            // 
            sidebar1.Location = new Point(-4, -29);
            sidebar1.Name = "sidebar1";
            sidebar1.Size = new Size(497, 1080);
            sidebar1.TabIndex = 0;
            // 
            // FormDashboardOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DashboardOwner;
            ClientSize = new Size(1904, 1041);
            Controls.Add(sidebar1);
            Name = "FormDashboardOwner";
            Text = "FormDashboardOwner";
            ResumeLayout(false);
        }

        #endregion

        private SidebarOwner sidebar1;
    }
}