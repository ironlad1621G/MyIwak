namespace MyMyIwak.Views.Admin
{
    partial class Pengiriman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pengiriman));
            sidebarAdmin2 = new SidebarAdmin();
            SuspendLayout();
            // 
            // sidebarAdmin2
            // 
            sidebarAdmin2.Location = new Point(0, 0);
            sidebarAdmin2.Name = "sidebarAdmin2";
            sidebarAdmin2.Size = new Size(497, 1080);
            sidebarAdmin2.TabIndex = 0;
            // 
            // Pengiriman
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1284, 781);
            Controls.Add(sidebarAdmin2);
            Name = "Pengiriman";
            Text = "Pengiriman";
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
        private SidebarAdmin sidebarAdmin2;
    }
}