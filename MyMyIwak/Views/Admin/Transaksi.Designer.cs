namespace MyMyIwak.Views.Admin
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            sidebarAdmin1 = new SidebarAdmin();
            transaksi1 = new Panel();
            transaksi2 = new Panel();
            transaksi3 = new Panel();
            SuspendLayout();
            // 
            // sidebarAdmin1
            // 
            sidebarAdmin1.Location = new Point(0, 0);
            sidebarAdmin1.Name = "sidebarAdmin1";
            sidebarAdmin1.Size = new Size(497, 1080);
            sidebarAdmin1.TabIndex = 0;
            // 
            // transaksi1
            // 
            transaksi1.BackColor = Color.Transparent;
            transaksi1.Location = new Point(573, 175);
            transaksi1.Name = "transaksi1";
            transaksi1.Size = new Size(283, 133);
            transaksi1.TabIndex = 1;
            // 
            // transaksi2
            // 
            transaksi2.BackColor = Color.Transparent;
            transaksi2.Location = new Point(930, 175);
            transaksi2.Name = "transaksi2";
            transaksi2.Size = new Size(283, 133);
            transaksi2.TabIndex = 2;
            // 
            // transaksi3
            // 
            transaksi3.BackColor = Color.Transparent;
            transaksi3.Location = new Point(1286, 175);
            transaksi3.Name = "transaksi3";
            transaksi3.Size = new Size(283, 133);
            transaksi3.TabIndex = 3;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1904, 1041);
            Controls.Add(transaksi3);
            Controls.Add(transaksi2);
            Controls.Add(transaksi1);
            Controls.Add(sidebarAdmin1);
            Name = "Transaksi";
            Text = "Transaksi";
            ResumeLayout(false);
        }

        #endregion

        private SidebarAdmin sidebarAdmin1;
        private Panel transaksi1;
        private Panel transaksi2;
        private Panel transaksi3;
    }
}