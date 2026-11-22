namespace MyMyIwak.Views.Owner
{
    partial class KelolaAkunAdmin
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
            label1 = new Label();
            lblTotalAdmin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarOwner1
            // 
            sidebarOwner1.Location = new Point(-5, -28);
            sidebarOwner1.Name = "sidebarOwner1";
            sidebarOwner1.Size = new Size(497, 1080);
            sidebarOwner1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalAdmin);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(607, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 154);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 17);
            label1.Name = "label1";
            label1.Size = new Size(178, 30);
            label1.TabIndex = 3;
            label1.Text = "Total Akun Admin";
            // 
            // lblTotalAdmin
            // 
            lblTotalAdmin.AutoSize = true;
            lblTotalAdmin.BackColor = Color.Transparent;
            lblTotalAdmin.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAdmin.Location = new Point(67, 67);
            lblTotalAdmin.Name = "lblTotalAdmin";
            lblTotalAdmin.Size = new Size(54, 65);
            lblTotalAdmin.TabIndex = 4;
            lblTotalAdmin.Text = "0";
            lblTotalAdmin.Click += lblTotalAdmin_Click;
            // 
            // KelolaAkunAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Controls.Add(sidebarOwner1);
            Name = "KelolaAkunAdmin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SidebarOwner sidebarOwner1;
        private Panel panel1;
        private Label label1;
        private Label lblTotalAdmin;
    }
}