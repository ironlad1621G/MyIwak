namespace MyMyIwak.Views
{
    partial class Sidebar
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
            btnDashboard = new Button();
            btnKelolaAkunAdmin = new Button();
            btnKelolaInventarisIkan = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Sidebar;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnKelolaInventarisIkan);
            panel1.Controls.Add(btnKelolaAkunAdmin);
            panel1.Controls.Add(btnDashboard);
            panel1.Location = new Point(1, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 1077);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.Location = new Point(68, 198);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(358, 68);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnKelolaAkunAdmin
            // 
            btnKelolaAkunAdmin.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaAkunAdmin.Location = new Point(68, 286);
            btnKelolaAkunAdmin.Name = "btnKelolaAkunAdmin";
            btnKelolaAkunAdmin.Size = new Size(358, 68);
            btnKelolaAkunAdmin.TabIndex = 1;
            btnKelolaAkunAdmin.Text = "Kelola Akun Admin";
            btnKelolaAkunAdmin.UseVisualStyleBackColor = true;
            btnKelolaAkunAdmin.Click += btnKelolaAkunAdmin_Click;
            // 
            // btnKelolaInventarisIkan
            // 
            btnKelolaInventarisIkan.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKelolaInventarisIkan.Location = new Point(68, 375);
            btnKelolaInventarisIkan.Name = "btnKelolaInventarisIkan";
            btnKelolaInventarisIkan.Size = new Size(358, 68);
            btnKelolaInventarisIkan.TabIndex = 2;
            btnKelolaInventarisIkan.Text = "Kelola Inventaris Ikan";
            btnKelolaInventarisIkan.UseVisualStyleBackColor = true;
            btnKelolaInventarisIkan.Click += btnKelolaInventarisIkan_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(68, 993);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 33);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // Sidebar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Sidebar";
            Size = new Size(497, 1080);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnKelolaInventarisIkan;
        private Button btnKelolaAkunAdmin;
        private Button btnDashboard;
        private Button btnLogout;
    }
}
