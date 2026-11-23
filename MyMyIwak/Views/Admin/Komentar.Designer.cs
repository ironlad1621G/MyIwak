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
            label1 = new Label();
            label2 = new Label();
            komentar1.SuspendLayout();
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
            komentar1.BackColor = Color.Transparent;
            komentar1.Controls.Add(label2);
            komentar1.Controls.Add(label1);
            komentar1.Location = new Point(567, 164);
            komentar1.Name = "komentar1";
            komentar1.Size = new Size(407, 152);
            komentar1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 10);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 0;
            label1.Text = "TOTAL KOMENTAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 52);
            label2.Name = "label2";
            label2.Size = new Size(55, 65);
            label2.TabIndex = 2;
            label2.Text = "0";
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
            komentar1.ResumeLayout(false);
            komentar1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
        private Panel komentar1;
        private Label label1;
        private Label label2;
    }
}