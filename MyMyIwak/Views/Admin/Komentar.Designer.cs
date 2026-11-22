namespace MyMyIwak.Views.Admin
{
    partial class Komentar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Komentar));
            sidebarAdmin1 = new SidebarAdmin();
            komentar1 = new Panel();
            SuspendLayout();
            // 
            // sidebarAdmin1
            // 
            sidebarAdmin1.Location = new Point(0, 0);
            sidebarAdmin1.Name = "sidebarAdmin1";
            sidebarAdmin1.Size = new Size(497, 1080);
            sidebarAdmin1.TabIndex = 0;
            // 
            // komentar1
            // 
            komentar1.Location = new Point(567, 164);
            komentar1.Name = "komentar1";
            komentar1.Size = new Size(367, 152);
            komentar1.TabIndex = 1;
            // 
            // Komentar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(komentar1);
            Controls.Add(sidebarAdmin1);
            Name = "Komentar";
            Text = "Komentar";
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
        private Panel komentar1;
    }
}