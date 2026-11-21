namespace MyMyIwak.Views
{
    partial class FormLogin
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
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(865, 437);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(921, 65);
            tbUsername.TabIndex = 1;
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 32.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(865, 563);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(921, 65);
            tbPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(255, 128, 0);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(862, 655);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(922, 67);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Login;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
    }
}