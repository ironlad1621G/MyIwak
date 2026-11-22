namespace MyMyIwak.Views.Admin
{
    partial class KelolaInventarisIkan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaInventarisIkan));
            sidebarAdmin1 = new SidebarAdmin();
            this.inventaris1 = new Panel();
            this.inventaris2 = new Panel();
            inventaris3 = new Panel();
            panel4 = new Panel();
            SuspendLayout();
            // 
            // sidebarAdmin1
            // 
            sidebarAdmin1.Location = new Point(0, 0);
            sidebarAdmin1.Name = "sidebarAdmin1";
            sidebarAdmin1.Size = new Size(497, 1080);
            sidebarAdmin1.TabIndex = 0;
            // 
            // inventaris1
            // 
            this.inventaris1.Location = new Point(562, 192);
            this.inventaris1.Name = "inventaris1";
            this.inventaris1.Size = new Size(255, 118);
            this.inventaris1.TabIndex = 1;
            // 
            // inventaris2
            // 
            this.inventaris2.Location = new Point(853, 192);
            this.inventaris2.Name = "inventaris2";
            this.inventaris2.Size = new Size(255, 118);
            this.inventaris2.TabIndex = 2;
            // 
            // inventaris3
            // 
            inventaris3.Location = new Point(1142, 192);
            inventaris3.Name = "inventaris3";
            inventaris3.Size = new Size(255, 118);
            inventaris3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(1432, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(255, 118);
            panel4.TabIndex = 4;
            // 
            // KelolaInventarisIkan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel4);
            Controls.Add(inventaris3);
            Controls.Add(this.inventaris2);
            Controls.Add(this.inventaris1);
            Controls.Add(sidebarAdmin1);
            Name = "KelolaInventarisIkan";
            Text = "KelolaInventarisIkan";
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
        private Panel inventaris1;
        private Panel inventaris2;
        private Panel inventaris3;
        private Panel panel4;
    }
}