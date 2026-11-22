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
            sidebarOwner1 = new SidebarOwner();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTotalAdmin = new Label();
            lblTotalVarianIkan = new Label();
            lblTotalStokIkan = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarOwner1
            // 
            sidebarOwner1.Location = new Point(-3, -30);
            sidebarOwner1.Name = "sidebarOwner1";
            sidebarOwner1.Size = new Size(497, 1080);
            sidebarOwner1.TabIndex = 0;
            sidebarOwner1.Load += sidebarOwner1_Load;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalAdmin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(623, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 154);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblTotalVarianIkan);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(623, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 154);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblTotalStokIkan);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(623, 614);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 154);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(68, 18);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 0;
            label1.Text = "Total Akun Admin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 24);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 1;
            label2.Text = "Total Varian Ikan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 28);
            label3.Name = "label3";
            label3.Size = new Size(147, 30);
            label3.TabIndex = 2;
            label3.Text = "Total Stok Ikan";
            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.AutoSize = true;
            lblTotalAdmin.BackColor = Color.Transparent;
            lblTotalAdmin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAdmin.Location = new Point(68, 63);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(54, 65);
            lblTotalAdmin.TabIndex = 1;
            lblTotalAdmin.Text = "0";
            lblTotalAdmin.Click += lblTotalAdmin_Click;
            // 
            // lblTotalVarianIkan
            // 
            lblTotalVarianIkan.AutoSize = true;
            lblTotalVarianIkan.BackColor = Color.Transparent;
            lblTotalVarianIkan.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalVarianIkan.Location = new Point(68, 69);
            lblTotalVarianIkan.Name = "lblTotalVarianIkan";
            lblTotalVarianIkan.Size = new Size(54, 65);
            lblTotalVarianIkan.TabIndex = 2;
            lblTotalVarianIkan.Text = "0";
            lblTotalVarianIkan.Click += lblTotalVarianIkan_Click;
            // 
            // lblTotalStokIkan
            // 
            lblTotalStokIkan.AutoSize = true;
            lblTotalStokIkan.BackColor = Color.Transparent;
            lblTotalStokIkan.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalStokIkan.Location = new Point(68, 72);
            lblTotalStokIkan.Name = "lblTotalStokIkan";
            lblTotalStokIkan.Size = new Size(54, 65);
            lblTotalStokIkan.TabIndex = 3;
            lblTotalStokIkan.Text = "0";
            lblTotalStokIkan.Click += lblTotalStokIkan_Click;
            // 
            // FormDashboardOwner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DashboardOwner;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(sidebarOwner1);
            Name = "FormDashboardOwner";
            Text = "FormDashboardOwner";
            Load += FormDashboardOwner_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SidebarOwner sidebar1;
        private SidebarOwner sidebarOwner1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Label lblTotalAdmin;
        private Label label2;
        private Label label3;
        private Label lblTotalVarianIkan;
        private Label lblTotalStokIkan;
    }
}