namespace MyMyIwak.Views.Customer
{
    partial class SidebarCustomer
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
            panel1 = new Panel();
            btnProfilSaya = new Button();
            btnRiwayatTransaksi = new Button();
            btnKeranjang = new Button();
            btnDashboard = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Sidebar;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnProfilSaya);
            panel1.Controls.Add(btnRiwayatTransaksi);
            panel1.Controls.Add(btnKeranjang);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 1074);
            panel1.TabIndex = 0;
            // 
            // btnProfilSaya
            // 
            btnProfilSaya.BackColor = Color.White;
            btnProfilSaya.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfilSaya.Location = new Point(69, 467);
            btnProfilSaya.Name = "btnProfilSaya";
            btnProfilSaya.Size = new Size(358, 68);
            btnProfilSaya.TabIndex = 4;
            btnProfilSaya.Text = "Profil Saya";
            btnProfilSaya.UseVisualStyleBackColor = false;
            btnProfilSaya.Click += btnProfilSaya_Click;
            // 
            // btnRiwayatTransaksi
            // 
            btnRiwayatTransaksi.BackColor = Color.White;
            btnRiwayatTransaksi.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRiwayatTransaksi.Location = new Point(69, 376);
            btnRiwayatTransaksi.Name = "btnRiwayatTransaksi";
            btnRiwayatTransaksi.Size = new Size(358, 68);
            btnRiwayatTransaksi.TabIndex = 3;
            btnRiwayatTransaksi.Text = "Riwayat Transaksi";
            btnRiwayatTransaksi.UseVisualStyleBackColor = false;
            btnRiwayatTransaksi.Click += btnRiwayatTransaksi_Click;
            // 
            // btnKeranjang
            // 
            btnKeranjang.BackColor = Color.White;
            btnKeranjang.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeranjang.Location = new Point(69, 286);
            btnKeranjang.Name = "btnKeranjang";
            btnKeranjang.Size = new Size(358, 68);
            btnKeranjang.TabIndex = 2;
            btnKeranjang.Text = "Keranjang";
            btnKeranjang.UseVisualStyleBackColor = false;
            btnKeranjang.Click += btnKeranjang_Click;
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
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(69, 982);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 33);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // SidebarCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SidebarCustomer";
            Size = new Size(497, 1080);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnProfilSaya;
        private Button btnRiwayatTransaksi;
        private Button btnKeranjang;
        private Button btnDashboard;
        private Button btnLogout;
    }
}
