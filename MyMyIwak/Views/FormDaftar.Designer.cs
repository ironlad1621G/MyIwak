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
            button1 = new Button();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama.Location = new Point(864, 206);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(921, 65);
            tbNama.TabIndex = 0;
            // 
            // tbNoTelepon
            // 
            tbNoTelepon.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNoTelepon.Location = new Point(864, 454);
            tbNoTelepon.Name = "tbNoTelepon";
            tbNoTelepon.Size = new Size(921, 65);
            tbNoTelepon.TabIndex = 1;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamat.Location = new Point(864, 578);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(921, 65);
            tbAlamat.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(864, 702);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(921, 65);
            tbPassword.TabIndex = 3;
            // 
            // tbKonfirmasiPassword
            // 
            tbKonfirmasiPassword.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbKonfirmasiPassword.Location = new Point(864, 826);
            tbKonfirmasiPassword.Name = "tbKonfirmasiPassword";
            tbKonfirmasiPassword.Size = new Size(921, 65);
            tbKonfirmasiPassword.TabIndex = 4;
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(864, 328);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(921, 65);
            tbUsername.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(863, 913);
            button1.Name = "button1";
            button1.Size = new Size(922, 67);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormDaftar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Daftar;
            ClientSize = new Size(1904, 1041);
            Controls.Add(button1);
            Controls.Add(tbUsername);
            Controls.Add(tbKonfirmasiPassword);
            Controls.Add(tbPassword);
            Controls.Add(tbAlamat);
            Controls.Add(tbNoTelepon);
            Controls.Add(tbNama);
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
        private Button button1;
    }
}