namespace MyMyIwak.Views.Admin
{
    partial class SidebarAdmin
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
            btnKomentar = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            btnTransaksi = new Button();
            btnKelolaInventarisIkan = new Button();
            btnDashboard = new Button();
            btnPengiriman = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKomentar
            // 
            btnKomentar.BackColor = Color.White;
            btnKomentar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKomentar.Location = new Point(69, 467);
            btnKomentar.Name = "btnKomentar";
            btnKomentar.Size = new Size(358, 68);
            btnKomentar.TabIndex = 4;
            btnKomentar.Text = "Komentar";
            btnKomentar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Sidebar;
            panel1.Controls.Add(btnPengiriman);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKomentar);
            panel1.Controls.Add(btnTransaksi);
            panel1.Controls.Add(btnKelolaInventarisIkan);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 1074);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(69, 983);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 33);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnTransaksi
            // 
            btnTransaksi.BackColor = Color.White;
            btnTransaksi.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTransaksi.Location = new Point(69, 376);
            btnTransaksi.Name = "btnTransaksi";
            btnTransaksi.Size = new Size(358, 68);
            btnTransaksi.TabIndex = 3;
            btnTransaksi.Text = "Transaksi";
            btnTransaksi.UseVisualStyleBackColor = false;
            // 
            // btnKelolaInventarisIkan
            // 
            btnKelolaInventarisIkan.BackColor = Color.White;
            btnKelolaInventarisIkan.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaInventarisIkan.Location = new Point(69, 286);
            btnKelolaInventarisIkan.Name = "btnKelolaInventarisIkan";
            btnKelolaInventarisIkan.Size = new Size(358, 68);
            btnKelolaInventarisIkan.TabIndex = 2;
            btnKelolaInventarisIkan.Text = "Kelola Inventaris Ikan";
            btnKelolaInventarisIkan.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(69, 196);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(358, 68);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnPengiriman
            // 
            btnPengiriman.BackColor = Color.White;
            btnPengiriman.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPengiriman.Location = new Point(69, 559);
            btnPengiriman.Name = "btnPengiriman";
            btnPengiriman.Size = new Size(358, 68);
            btnPengiriman.TabIndex = 6;
            btnPengiriman.Text = "Pengiriman";
            btnPengiriman.UseVisualStyleBackColor = false;
            // 
            // SidebarAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SidebarAdmin";
            Size = new Size(497, 1080);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnKomentar;
        private Panel panel1;
        private Button btnTransaksi;
        private Button btnKelolaInventarisIkan;
        private Button btnDashboard;
        private Button btnLogout;
        private Button btnPengiriman;
    }
}
