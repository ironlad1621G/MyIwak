namespace MyMyIwak.Views
{
    partial class FormTampilanAwal
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
            btnLogin = new Button();
            btnDaftar = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(609, 738);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(324, 80);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(255, 128, 0);
            btnDaftar.Cursor = Cursors.Hand;
            btnDaftar.FlatStyle = FlatStyle.Popup;
            btnDaftar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDaftar.ForeColor = Color.White;
            btnDaftar.Location = new Point(986, 738);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(324, 80);
            btnDaftar.TabIndex = 1;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            btnDaftar.Click += button2_Click;
            // 
            // FormTampilanAwal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tampilan_Awal;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnDaftar);
            Controls.Add(btnLogin);
            DoubleBuffered = true;
            Name = "FormTampilanAwal";
            Text = "FormTampilanAwal";
            Load += FormTampilanAwal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnDaftar;
    }
}