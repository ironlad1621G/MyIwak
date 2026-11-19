namespace MyMyIwak.Views
{
    partial class TampilanAwal
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
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(278, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnDaftar
            // 
            btnDaftar.BackColor = Color.FromArgb(255, 128, 0);
            btnDaftar.FlatStyle = FlatStyle.Flat;
            btnDaftar.Location = new Point(425, 316);
            btnDaftar.Name = "btnDaftar";
            btnDaftar.Size = new Size(94, 29);
            btnDaftar.TabIndex = 1;
            btnDaftar.Text = "Daftar";
            btnDaftar.UseVisualStyleBackColor = false;
            // 
            // TampilanAwal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Tampilan_Awal__3_;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDaftar);
            Controls.Add(btnLogin);
            Name = "TampilanAwal";
            Text = "TampilanAwal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private Button btnDaftar;
    }
}