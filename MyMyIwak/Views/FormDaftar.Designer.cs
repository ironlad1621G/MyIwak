namespace MyMyIwak.Views
{
    partial class FormDaftar
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
            tbNama = new TextBox();
            tbNoTelepon = new TextBox();
            tbAlamat = new TextBox();
            tbPassword = new TextBox();
            tbKonfirmasiPassword = new TextBox();
            tbUsername = new TextBox();
            btnDaftar = new Button();
            btnKeluar = new Button();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(864, 206);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(921, 65);
            tbNama.TabIndex = 0;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // tbNoTelepon
            // 
            tbNoTelepon.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoTelepon.Location = new Point(864, 454);
            tbNoTelepon.Name = "tbNoTelepon";
            tbNoTelepon.Size = new Size(921, 65);
            tbNoTelepon.TabIndex = 1;
            tbNoTelepon.TextChanged += tbNoTelepon_TextChanged;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamat.Location = new Point(864, 578);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(921, 65);
            tbAlamat.TabIndex = 2;
            tbAlamat.TextChanged += tbAlamat_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(864, 702);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(921, 65);
            tbPassword.TabIndex = 3;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // tbKonfirmasiPassword
            // 
            tbKonfirmasiPassword.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbKonfirmasiPassword.Location = new Point(864, 826);
            tbKonfirmasiPassword.Name = "tbKonfirmasiPassword";
            tbKonfirmasiPassword.Size = new Size(921, 65);
            tbKonfirmasiPassword.TabIndex = 4;
            tbKonfirmasiPassword.TextChanged += tbKonfirmasiPassword_TextChanged;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(864, 328);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(921, 65);
            tbUsername.TabIndex = 5;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(255, 128, 0);
            btnDaftar.Cursor = Cursors.Hand;
            btnDaftar.FlatStyle = FlatStyle.Popup;
            btnDaftar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = Color.White;
            btnDaftar.Location = new Point(863, 912);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(922, 67);
            btnDaftar.TabIndex = 6;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += btnDatar_Click;
            // 
            // btnKeluar
            // 
            btnKeluar.BackColor = Color.FromArgb(255, 128, 0);
            btnKeluar.Cursor = Cursors.Hand;
            btnKeluar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnKeluar.ForeColor = Color.White;
            btnKeluar.Location = new Point(71, 956);
            btnKeluar.Name = "btnKeluar";
            btnKeluar.Size = new Size(131, 42);
            btnKeluar.TabIndex = 9;
            btnKeluar.Text = "Keluar";
            btnKeluar.UseVisualStyleBackColor = false;
            btnKeluar.Click += btnKeluar_Click;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Daftar;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnKeluar);
            Controls.Add(btnDaftar);
            Controls.Add(tbUsername);
            Controls.Add(tbKonfirmasiPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbAlamat);
            Controls.Add(tbNoTelepon);
            Controls.Add(tbNama);
            DoubleBuffered = true;
            Name = "FormDaftar";
            Text = "FormDaftar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private TextBox tbNoTelepon;
        private TextBox tbAlamat;
        private TextBox tbPassword;
        private TextBox tbKonfirmasiPassword;
        private TextBox tbUsername;
        private Button btnDaftar;
        private Button btnKeluar;
    }
}